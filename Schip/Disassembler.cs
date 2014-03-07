using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schip
{
    class Disassembler
    {
        SchipMachine machine;
        public Disassembler(SchipMachine machine)
        {
            this.machine = machine;
        }

        public string DecodeInstruction()
        {
            //se lee la proxima instrucción
            ushort pc = machine.Cpu.Pc;
            ushort byte1 = machine.Ram.ReadByte(pc);
            ushort byte2 = machine.Ram.ReadByte(pc + 1U);
            ushort instruction = (ushort)(byte1 << 8 | byte2);

            //Se extraen los opcodes y otros registros
            byte opcode1 = (byte)(instruction >> 12);
            byte opcode2 = (byte)((instruction & 0x0F00) >> 8);
            byte opcode3 = (byte)((instruction & 0x00F0) >> 4);
            byte opcode4 = (byte)(instruction & 0x000F);
            byte kk = (byte)(instruction & 0x00FF);
            ushort nnn = (ushort)(instruction & 0x0FFF);

            // Se ejecuta la operación de acuerdo a opocode1
            string hexOpCode = Convert.ToString(instruction, 16).PadLeft(4, '0').ToUpper();
            switch (opcode1)
            {
                case 0x0:
                    switch(instruction){
                        case 0x00E0: //Clear display
                            return hexOpCode + " -> CLS --Clear display";
                        case 0x00EE: //Return from subroutine call
                            return hexOpCode + " -> RET --Return from subroutine call";
                        case 0x00FB: //Scroll display 4 pixels right
                            return hexOpCode + " -> SCR --Scroll display 4 pixels right";
                        case 0x00FC: //Scroll display 4 pixels left
                            return hexOpCode + " -> SCL --Scroll display 4 pixels left";
                        case 0x00FD: //Exit CHIP interpreter
                            return hexOpCode + " -> EXIT --Exit CHIP interpreter";
                        case 0x00FE: //Disable extended screen mode (64x32)
                            return hexOpCode + " -> LOW --Disable extended screen mode";
                        case 0x00FF: //Enable extended screen mode for full-screen graphics (128x64)
                            return hexOpCode + " -> HIGH --Enable extended screen mode";
                        default:
                            if (opcode3 == 0xC && opcode2 == 0) //Scroll down N lines
                            {
                                return hexOpCode + " -> SCD " + opcode4 + " --Scroll down " + opcode4 + " lines ";
                            }
                            else if ((instruction & 0xFFF) != 0)
                            {
                                //0nnn - SYS addr
                                //Jump to a machine code routine at nnn.
                                //This instruction is only used on the old computers on which Chip-8 was originally implemented. It is ignored by modern interpreters.
                                return hexOpCode + "SYS -> " + nnn + " --Jump to a machine code routine at " + nnn;
                            }
                            else
                            {
                                //throw new Exception("Unknown Opcode: 0x" + Convert.ToString(instruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                                return hexOpCode + " -> Unknown instruction";
                            }
                    }
                case 0x1: //Jump to NNN
                    return hexOpCode + " -> JP " + nnn + " --Jump to " + nnn;
                case 0x2: //Call subroutine at NNN
                    return hexOpCode + " -> CALL " + nnn + " --Call subroutine at " + nnn;
                case 0x3: //Skip next instruction if VX == KK
                    return hexOpCode + " -> SE V" + opcode2 + ", " + kk + " --Skip next instruction if V" + opcode2 + " == " + kk;
                case 0x4: //Skip next instruction if VX <> KK
                    return hexOpCode + " -> SNE V" + opcode2 + ", " + kk + " --Skip next instruction if V" + opcode2 + " != " + kk;
                case 0x5: //Skip next instruction if VX == VY
                    return hexOpCode + " -> SE V" + opcode2 + ", V" + opcode3 + " --Skip next instruction if V" + opcode2 + " == V" + opcode3;
                case 0x6: //VX := KK
                    return hexOpCode + " -> LD V" + opcode2 + ", " + kk + " --V" + opcode2 + " := " + kk;
                case 0x7: //VX := VX + KK
                    return hexOpCode + " -> ADD V" + opcode2 + ", " + kk + " --V" + opcode2 + " := V" + opcode2 + " + "+ kk;
                case 0x8:
                    switch(opcode4){
                        case 0x0: //VX := VY, VF may change 
                            return hexOpCode + " -> LD V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode3;
                        case 0x1: //VX := VX or VY, VF may change
                            return hexOpCode + " -> OR V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode2 + " or V"+ opcode3;
                        case 0x2: //VX := VX and VY, VF may change
                            return hexOpCode + " -> AND V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode2 + " and V"+ opcode3;
                        case 0x3: //VX := VX xor VY, VF may change
                            return hexOpCode + " -> XOR V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode2 + " xor V"+ opcode3;
                        case 0x4: //VX := VX + VY, VF := carry
                            return hexOpCode + " -> ADD V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode2 + " + V"+ opcode3 + ", VF := carry";
                        case 0x5: //VX := VX - VY, VF := not borrow
                            return hexOpCode + " -> SUB V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode2 + " - V"+ opcode3 + ", VF := !borrow";
                        case 0x6: //VX := VX shr 1, VF := carry
                            return hexOpCode + " -> SHR V" + opcode2 + " --V" + opcode2 + " := V" + opcode2 + " shr 1, VF := carry";
                        case 0x7: //VX := VY - VX, VF := not borrow
                            return hexOpCode + " -> SUBN V" + opcode2 + ", V" + opcode3 + " --V" + opcode2 + " := V" + opcode3 + " - V"+ opcode2 + ", VF := !borrow";
                        case 0xE: //VX := VX shl 1, VF := carry
                            return hexOpCode + " -> SHL V" + opcode2 + " --V" + opcode2 + " := V" + opcode2 + " shl 1, VF := carry";
                        default:
                            return hexOpCode + " -> Unknown instruction";
                    }
                case 0x9: //Skip next instruction if VX <> VY
                    return hexOpCode + " -> SNE V" + opcode2 + ", V" + opcode3 + " --Skip next instruction if V" + opcode2 + " != V" + opcode3;
                case 0xA: //I := NNN
                    return hexOpCode + " -> LD I, " + nnn + " --I := " + nnn;
                case 0xB: //Jump to NNN+V0
                    return hexOpCode +"JP V0, " + nnn + "Jump to V0 + " + nnn;
                case 0xC: //VX := pseudorandom_number and KK
                    return hexOpCode + " -> RND V" + opcode2 + ", " + kk + " --V" + opcode2 + " := rand(256) and "+ kk;
                case 0xD: //Show N-byte sprite from M(I) at coords (VX,VY), VF :=collision.
                    return hexOpCode + " -> DRW V" + opcode2 + ", V" + opcode3 + ", " + opcode4 + " -- Draw sprite M(I) at (V" + opcode2 + ", V" + opcode3 + "). VF := collision";
                case 0xE:
                    switch(kk){
                        case 0x9E: //Skip next instruction if key VX pressed
                            return hexOpCode + " -> SKP V" + opcode2 + " --Skip next instruction if key V" + opcode2 + " is pressed";
                        case 0xA1: //Skip next instruction if key VX not pressed
                            return hexOpCode + " -> SKNP V" + opcode2 + " --Skip next instruction if key V" + opcode2 + " is not pressed";
                        default:
                            //throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                            return hexOpCode + " -> Unknown instruction";
                    }
                case 0xF:
                    switch(kk){
                        case 0x07: //VX := delay_timer
                            return hexOpCode + " -> LD V" + opcode2 + ", DT --V" + opcode2 + " := DT";
                        case 0x0A: //wait for keypress, store hex value of key in VX
                            return hexOpCode + " -> LD V" + opcode2 + ", KP --V" + opcode2 + " := KeyPressed";
                        case 0x15: //delay_timer := VX
                            return hexOpCode + " -> LD DT, V" + opcode2 + " --DT := V" + opcode2 ;
                        case 0x18: //sound_timer := VX
                            return hexOpCode + " -> LD ST, V" + opcode2 + " --DT := V" + opcode2 ;
                        case 0x1E: //I := I + VX
                            return hexOpCode + " -> ADD I, V" + opcode2 + " --I := I + V" + opcode2;
                        case 0x29: //Point I to 5-byte font sprite for hex character VX
                            return hexOpCode + " -> LD I, LF(V" + opcode2 + ") --Set I to Chip8 Font V" + opcode2;
                        case 0x30: //Point I to 10-byte font sprite for digit VX (0..9)
                            return hexOpCode +" -> LD I, HF(V" + opcode2 + ") --Set I to SChip8 Font V" + opcode2;
                        case 0x33: //Store BCD representation of VX in M(I)..M(I+2)
                            return hexOpCode + " -> BCD V" + opcode2 + " --Store BCD representation of V" + opcode2 + " in M(I)..M(I+2)";
                        case 0x55: //Store V0..VX in memory starting at M(I)
                            return hexOpCode + " -> LD [I], V" + opcode2 + " --Store V0..V" + opcode2 + " in memory starting at I";
                        case 0x65: //Read V0..VX from memory starting at M(I)
                            return hexOpCode + " -> LD V" + opcode2 + ", [i]" + " --Read V0..V" + opcode2 + " from memory starting at I";
                        case 0x75: //Store V0..VX in RPL user flags (X <= 7)
                            return hexOpCode + " -> LD R, V" + opcode2 + " --Store V0..V" + opcode2 + " in RPL user flags";
                        case 0x85: //Read V0..VX from RPL user flags (X <= 7)
                            return hexOpCode +  " -> LD V, R" + opcode2 + " --Read V0..V" + opcode2 + " from RPL user flags";
                        default:
                            //throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                            return hexOpCode + " -> Unknown instruction";
                    }
                default:
                    //throw new Exception("Unknown Opcode: 0x" + Convert.ToString(currentInstruction, 16) + " at 0x" + Convert.ToString(pc - 0x202, 16));
                    return hexOpCode + " -> Unknown instruction";
            }
        }
    }
}
