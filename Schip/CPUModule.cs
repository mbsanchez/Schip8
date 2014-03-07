using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Schip
{
    class CPUModule
    {
        #region definicion de constantes
        public const int STACK_SIZE = 0x10;
        public const int BEGIN_INSTRUCTION = 0x200;
        public const int REG_SIZE = 0x10;
        public const int HP8_FLAG_SIZE = 0x10;
        private const int DEFAULT_INSTRUCTION_BY_SECOND = 1000;
        //private static double INSTRUCTIONS_BY_FRAME = INSTRUCTION_BY_SECOND / 60;
        public static readonly Random rnd = new Random();
        public const byte F = 0xF;
        #endregion

        #region atributos (registros del CPU)
        private byte delayTimer;
        private byte soundTimer;
        private byte[] v;
        private byte[] hp48;
        private ArrayIntStack stack;

        private ushort pc;
        private ushort ir;
        private byte kk;

        //variables para manejar los opcodes
        private byte opcode1 = 0;
        private byte opcode2 = 0;  //X
        private byte opcode3 = 0;  //Y
        private byte opcode4 = 0;

        private ushort currentInstruction;
        private bool emitSound;
        private Stopwatch cpuStopWatch;
        private Stopwatch videoStopWatch;
        private double Hz = DEFAULT_INSTRUCTION_BY_SECOND / 62.5d;
        private double videoFrameRate = 1000/60d;
        #endregion

        #region delegados para eventos de actualizacion de pantalla
        public delegate void UpdateScreenEvent();
        public UpdateScreenEvent UpdateDisplay;
        #endregion

        #region estado del cpu
        public enum EmulationState { Running, Paused, Stopped };
        #endregion

        #region metodos getter
        public ushort Pc { get { return pc; } }
        public ushort I { get { return ir; } }
        public byte KK { get { return kk; } }
        public byte DelayTimer { get { return delayTimer; } }
        public byte SoundTimer { get { return soundTimer; } }
        public ArrayIntStack Stack { get { return stack; } }
        public byte[] V { get { return v; } }
        public byte[] Hp48 { get { return v; } }
        public ushort CurrentInstruction { get { return currentInstruction; } }
        public EmulationState CPUState { get; set; }
        public bool IsRunning { get; set; }
        #endregion

        #region objetos externos necesarios
        private SchipMachine machine;
        #endregion

        #region constructores
        public CPUModule(SchipMachine machine)
        {
            this.machine = machine;
            stack = new ArrayIntStack(STACK_SIZE);
            v = new byte[REG_SIZE];
            hp48 = new byte[HP8_FLAG_SIZE];
            cpuStopWatch = new Stopwatch();
            videoStopWatch = new Stopwatch();
            CPUState = EmulationState.Stopped;

            this.Init();
        }
        #endregion

        #region otros métodos
        public void Init(){
            //Resetear timers
            delayTimer =  soundTimer = 0;
            emitSound = false;
            IsRunning = false;

            //Resetear los registros
            opcode1 = 0;
            opcode2 = 0;
            opcode3 = 0;
            opcode4 = 0;
            pc = BEGIN_INSTRUCTION;
            ir = 0;
            kk = 0;
            currentInstruction = 0;

            //Borrar el valor de los registros
            for(int i=0;i<REG_SIZE;i++)
                v[i] = 0;

            //Borrar el valor de las banderas hp48
            for(int i=0;i<HP8_FLAG_SIZE;i++)
                hp48[i] = 0;

            //Resetear la pila
            stack.Clear();
            cpuStopWatch.Reset();
            videoStopWatch.Reset();

            if (UpdateDisplay != null) new Thread(new ThreadStart(UpdateDisplay)).Start();
        }

        public void PlaySound()
        {
            Console.Beep(450, 100);
        }

        public void Run() {
            CPUState = EmulationState.Running;
            videoStopWatch.Restart();
            IsRunning = true;

            while (CPUState == EmulationState.Running)
            {
                for (int i = 0; i < 5; i++)
                {
                    EmulateInstruction();
                    Thread.Sleep(0);
                }
                Thread.Sleep(8);
            }
            cpuStopWatch.Stop();
            videoStopWatch.Stop();
            IsRunning = false;
        }

        public void EmulateInstruction() 
        {
            RunInstruction();
            UpdateTimers();
            TestForUpdateDisplay();
        }

        private void TestForUpdateDisplay() {
            if (!videoStopWatch.IsRunning)
                videoStopWatch.Restart();
            if (videoStopWatch.Elapsed.TotalMilliseconds >= videoFrameRate) {
                videoStopWatch.Restart();
                fireUpdateDisplayEvent();
            }
        }

        private void UpdateTimers() {
            if (emitSound && soundTimer>0)
            {
                emitSound = false;
                new Thread(new ThreadStart(PlaySound)).Start();
            }

            if (delayTimer == 0 && soundTimer == 0)
                cpuStopWatch.Stop();
            else if (!cpuStopWatch.IsRunning)
            {
                cpuStopWatch.Restart();
            }

            if (cpuStopWatch.Elapsed.TotalMilliseconds >= Hz)
            {
                cpuStopWatch.Restart();

                if (delayTimer > 0) delayTimer--;
                if (soundTimer > 0) soundTimer--;
            }
        }

        private void fireUpdateDisplayEvent()
        {
            if (UpdateDisplay != null) new Thread(new ThreadStart(UpdateDisplay)).Start();
        }

        private void RunInstruction()
        {
            //se lee la proxima instrucción
            ushort byte1 = machine.Ram.ReadByte(pc);
            ushort byte2 = machine.Ram.ReadByte(pc+1U);
            currentInstruction =  (ushort)(byte1 << 8 | byte2);

            //mueve el PC a la próxima instrucción
            pc += 2;

            //Se extraen los opcodes y otros registros
            opcode1 = (byte)(currentInstruction >> 12);
            opcode2 = (byte)((currentInstruction & 0x0F00) >> 8);
            opcode3 = (byte)((currentInstruction & 0x00F0) >> 4);
            opcode4 = (byte)(currentInstruction & 0x000F);
            kk = (byte)(currentInstruction & 0x00FF);

            // Se ejecuta la operación de acuerdo a opocode1
            switch (opcode1)
            {
                case 0x0:
                    switch(currentInstruction){
                        case 0x00E0: //Clear display
                            machine.Video.ClearScreen();
                            break;
                        case 0x00EE: //return from subroutine call
                            pc = (ushort)stack.Top();
                            stack.Pop();
                            break;
                        case 0x00FB: //Scroll display 4 pixels right
                              machine.Video.ScrollRight(4);
                            break;
                        case 0x00FC: //Scroll display 4 pixels left
                            machine.Video.ScrollLeft(4);
                            break;
                        case 0x00FD: //Exit CHIP interpreter
                            machine.ResetHardware();
                            break;
                        case 0x00FE: //Disable extended screen mode (64x32)
                            machine.Video.CurrentMode = VideoModule.VideoMode.Chip8Mode;
                            break;
                        case 0x00FF: //Enable extended screen mode for full-screen graphics (128x64)
                            machine.Video.CurrentMode = VideoModule.VideoMode.SChipMode;
                            break;
                        default:
                            if (opcode3 == 0xC && opcode2 == 0) //Scroll down N lines
                            {
                                machine.Video.ScrollDown(opcode4);
                            }
                            else if ((currentInstruction & 0xFFF) != 0)
                            {
                                //0nnn - SYS addr
                                //Jump to a machine code routine at nnn.
                                //This instruction is only used on the old computers on which Chip-8 was originally implemented. It is ignored by modern interpreters.
                            }
                            else
                            {
                                throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                            }
                            break;
                    }
                    break;
                case 0x1: //Jump to NNN
                    pc = (ushort)(currentInstruction & 0xFFF);
                    break;
                case 0x2: //Call subroutine at NNN
                    stack.Push(pc);
                    pc = (ushort)(currentInstruction & 0xFFF);
                    break;
                case 0x3: //Skip next instruction if VX == KK
                    if (v[opcode2] == kk) pc += 2;
                    break;
                case 0x4: //Skip next instruction if VX <> KK
                    if (v[opcode2] != kk) pc += 2;
                    break;
                case 0x5: //Skip next instruction if VX == VY
                    if (v[opcode2] == v[opcode3]) pc += 2;
                    break;
                case 0x6: //VX := KK
                    v[opcode2] = kk;
                    break;
                case 0x7: //VX := VX + KK
                    v[opcode2] += kk;
                    break;
                case 0x8:
                    switch(opcode4){
                        case 0x0: //VX := VY, VF may change 
                            v[opcode2] = v[opcode3];
                            break;
                        case 0x1: //VX := VX or VY, VF may change
                            v[opcode2] |= v[opcode3];
                            break;
                        case 0x2: //VX := VX and VY, VF may change
                            v[opcode2] &= v[opcode3];
                            break;
                        case 0x3: //VX := VX xor VY, VF may change
                            v[opcode2] ^= v[opcode3];
                            break;
                        case 0x4: //VX := VX + VY, VF := carry
                            uint suma = (uint)(v[opcode2] + v[opcode3]);
                            v[opcode2] = (byte)suma;
                            v[F] = (byte)(suma >> 8);
                            break;
                        case 0x5: //VX := VX - VY, VF := not borrow
                            v[F] = (byte)(v[opcode2] >= v[opcode3] ? 1 : 0);
                            v[opcode2] -= v[opcode3];
                            break;
                        case 0x6: //VX := VX shr 1, VF := carry
                            //if (opcode3 == 0) //Si OPCODE3 no esta presente se desplaza VX
                            //{
                                //VF = VX AND 1
                                v[F] = (byte)(v[opcode2] & 0x1);
                                v[opcode2] >>= 1;
                            /*}
                            else //Si opcode3 está presente se desplaza VY
                            {
                                //VF = VY AND 1
                                v[F] = (byte)(v[opcode3] & 0x1);
                                v[opcode2] = (byte)(v[opcode3] >> 1);
                            }*/
                            break;
                        case 0x7: //VX := VY - VX, VF := not borrow
                            v[F] = (byte)(v[opcode3] >= v[opcode2] ? 1 : 0);
                            v[opcode2] = (byte)(v[opcode3] - v[opcode2]);
                            break;
                        case 0xE: //VX := VX shl 1, VF := carry
                            /*if (opcode3 == 0) //Si OPCODE3 no esta presente se desplaza VX
                            {*/
                                //VF = bit 7 de VX
                                v[F] = (byte)(v[opcode2] >> 7);
                                v[opcode2] <<= 1;
                            /*}
                            else //Si opcode3 está presente se desplaza VY
                            {
                                //VF = bit 7 de VY 
                                v[F] = (byte)(v[opcode3] >> 7);
                                v[opcode2] = (byte)(v[opcode3] << 1);
                            }*/
                            break;
                        default:
                            throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                    }
                    break;
                case 0x9: //Skip next instruction if VX <> VY
                    if (v[opcode2] != v[opcode3]) pc += 2;
                    break;
                case 0xA: //I := NNN
                    ir = (ushort)(currentInstruction & 0xFFF);
                    break;
                case 0xB: //Jump to NNN+V0
                    ir = (ushort)((currentInstruction & 0xFFF) + v[0]);
                    break;
                case 0xC: //VX := pseudorandom_number and KK
                    byte r = (byte)rnd.Next(0, 256);
                    v[opcode2] = (byte)(r & kk);
                    break;
                case 0xD: //Show N-byte sprite from M(I) at coords (VX,VY), VF :=collision.
                    v[F] = machine.Video.Draw(machine.Ram, ir, v[opcode2], v[opcode3], opcode4);
                    break;
                case 0xE:
                    switch(kk){
                        case 0x9E: //Skip next instruction if key VX pressed
                            if(machine.Keys[v[opcode2]])
                                pc += 2;
                            break;
                        case 0xA1: //Skip next instruction if key VX not pressed
                            if (!machine.Keys[v[opcode2]])
                                pc += 2;
                            break;
                        default:
                            throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                    }
                    break;
                case 0xF:
                    switch(kk){
                        case 0x07: //VX := delay_timer
                            v[opcode2] = delayTimer;
                            break;
                        case 0x0A: //wait for keypress, store hex value of key in VX
                            pc -= 2;
                            for (int i = 0; i < machine.Keys.Length; i++)
                            {
                                if (machine.Keys[i])
                                {
                                    v[opcode2] = (byte)i;
                                    pc += 2;
                                }
                            }
                            break;
                        case 0x15: //delay_timer := VX
                            delayTimer = v[opcode2];
                            break;
                        case 0x18: //sound_timer := VX
                            soundTimer = v[opcode2];
                            emitSound = true;
                            break;
                        case 0x1E: //I := I + VX
                            ir += v[opcode2];
                            v[F] =(byte) ((ir > 0xFFF) ? 1 : 0);
                            break;
                        case 0x29: //Point I to 5-byte font sprite for hex character VX
                            ir = (ushort)((v[opcode2] & 0xF) * 5);
                            break;
                        case 0x30: //Point I to 10-byte font sprite for digit VX (0..9)
                            ir = (ushort)(80 + (v[opcode2] & 0xF) * 10);
                            break;
                        case 0x33: //Store BCD representation of VX in M(I)..M(I+2)
                            int vx = v[opcode2];
                            machine.Ram.WriteByte(ir, (byte)(vx / 100));			//centenas
                            machine.Ram.WriteByte(ir + 1U, (byte)((vx / 10) % 10));	//decenas
                            machine.Ram.WriteByte(ir + 2U, (byte)(vx % 10));		//unidades
                            break;
                        case 0x55: //Store V0..VX in memory starting at M(I)
                            for (uint i = 0; i <= opcode2; i++)
                                machine.Ram.WriteByte(ir + i, v[i]);
                            break;
                        case 0x65: //Read V0..VX from memory starting at M(I)
                            for (uint i = 0; i <= opcode2; i++)
                                v[i] = machine.Ram.ReadByte(ir + i);
                            break;
                        case 0x75: //Store V0..VX in RPL user flags (X <= 7)
                            for (uint i = 0; i <= opcode2; i++)
                                hp48[i] = v[i];
                            break;
                        case 0x85: //Read V0..VX from RPL user flags (X <= 7)
                            for (uint i = 0; i <= opcode2; i++)
                                v[i] = hp48[i];
                            break;
                        default:
                            throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                    }
                    break;
                default:
                    throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
            }
        }
 
        #endregion
    }
}
