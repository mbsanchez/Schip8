using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Schip
{
    class SchipMachine
    {
        #region definicion de constantes
        public const int RAM_SIZE = 0x1000;
        #endregion

        #region componentes de la maquina
        private MemoryModule ram;
        private VideoModule video;
        private CPUModule cpu;
        private bool[] keys;
        private bool programLoaded;
        #endregion

        #region vector de fuentes
        public static readonly byte[] fonts = {
	                                            0xF0, 0x90, 0x90, 0x90, 0xF0,	// valores para 0
	                                            0x60, 0xE0, 0x60, 0x60, 0xF0,	// valores para 1
	                                            0x60, 0x90, 0x20, 0x40, 0xF0,	// valores para 2
	                                            0xF0, 0x10, 0xF0, 0x10, 0xF0,	// valores para 3
	                                            0x90, 0x90, 0xF0, 0x10, 0x10,	// valores para 4
	                                            0xF0, 0x80, 0x60, 0x10, 0xE0,	// valores para 5
	                                            0xF0, 0x80, 0xF0, 0x90, 0xF0,	// valores para 6
	                                            0xF0, 0x10, 0x10, 0x10, 0x10,	// valores para 7
	                                            0xF0, 0x90, 0xF0, 0x90, 0xF0,	// valores para 8
	                                            0xF0, 0x90, 0xF0, 0x10, 0x10,	// valores para 9
	                                            0x60, 0x90, 0xF0, 0x90, 0x90,	// valores para A
	                                            0xE0, 0x90, 0xE0, 0x90, 0xE0,	// valores para B
	                                            0x70, 0x80, 0x80, 0x80, 0x70,	// valores para C
	                                            0xE0, 0x90, 0x90, 0x90, 0xE0,	// valores para D
	                                            0xF0, 0x80, 0xF0, 0x80, 0xF0,	// valores para E
	                                            0xF0, 0x80, 0xF0, 0x80, 0x80	// valores para F
                                              };

        public static readonly byte[] fontsSChip = {   //SChip
		                                            0x18, 0x3c, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x18,
		                                            0x0c, 0x1c, 0x3c, 0x0c, 0x0c, 0x0c, 0x0c, 0x0c, 0x3e, 0x3e,
                                                    0x3c, 0x7e, 0x66, 0x06, 0x0e, 0x1c, 0x38, 0x70, 0x7e, 0x7e,
                                                    0x3c, 0x7e, 0x66, 0x06, 0x1c, 0x1e, 0x06, 0x66, 0x7e, 0x3c,
                                                    0x0c, 0x1c, 0x1c, 0x3c, 0x2c, 0x6e, 0x7e, 0x0c, 0x0c, 0x1e,
                                                    0x7E, 0x7E, 0x60, 0x60, 0x7c, 0x3E, 0x06, 0x66, 0x7C, 0x38,
                                                    0x1c, 0x3c, 0x70, 0x60, 0x7C, 0x66, 0x66, 0x66, 0x3C, 0x18,
                                                    0x7E, 0x7E, 0x06, 0x06, 0x0c, 0x1c, 0x38, 0x30, 0x30, 0x30,
                                                    0x18, 0x3c, 0x66, 0x66, 0x3c, 0x7E, 0x66, 0x66, 0x7e, 0x3C,
                                                    0x3c, 0x7E, 0x66, 0x66, 0x66, 0x3E, 0x06, 0x0E, 0x3C, 0x38,
                                                    0x18, 0x18, 0x3c, 0x24, 0x24, 0x66, 0x7E, 0x66, 0x66, 0x66,
                                                    0x7C, 0x7E, 0x66, 0x66, 0x7C, 0x7E, 0x66, 0x66, 0x7E, 0x7C,
                                                    0x1c, 0x3E, 0x76, 0x60, 0x60, 0x60, 0x60, 0x76, 0x3E, 0x1C,
                                                    0x7C, 0x7E, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x7E, 0x7C,
                                                    0x7E, 0x7E, 0x60, 0x60, 0x7C, 0x7C, 0x60, 0x60, 0x7e, 0x7e,
                                                    0x7E, 0x7E, 0x60, 0x60, 0x7C, 0x7C, 0x60, 0x60, 0x60, 0x60
                                                   };
        #endregion

        #region teclado
        public static readonly byte[] Keyboard = {	       
	                                                0x01,0x02,0x03,0x0C,
	                                                0x04,0x05,0x06,0x0D,
	                                                0x07,0x08,0x09,0x0E,
	                                                0x0A,0x00,0x0B,0x0F 
                                                  };
        #endregion

        #region metodos getter y setter
        public MemoryModule Ram { get {return ram;} }
        public VideoModule Video { get { return video; } }
        public CPUModule Cpu { get { return cpu; } }
        public bool[] Keys { get { return keys; } }
        #endregion

        #region constructores
        public SchipMachine()
        {
            ram = new MemoryModule(RAM_SIZE);
            video = new VideoModule();
            cpu = new CPUModule(this);

            keys = new bool[16];
        }
        #endregion

        #region otros métodos
        public void ResetHardware()
        {
            //Detener el CPU si se encuentra en ejecución
            StopProgram();

            // limpiar la memoria
            ram.Clear();
            programLoaded = false;
            
            // Carga de Fuentes Chip8 a Memoria (eran 80 bytes, 5 byte por cada una de las 16 letras)
            for (uint i = 0; i < fonts.Length; i++)
            {
                ram.WriteByte(i,  fonts[i]);
            }

            //Cargar las fuentes Schip a memoria (son 160 bytes, 10 bytes por cada una de las 16 letras)
            for (uint i = 0; i < fontsSChip.Length; i++)
            {
                ram.WriteByte(i+80, fontsSChip[i]);
            }

            //limpiar las teclas
            for (int i = 0; i < keys.Length; i++)
                keys[i] = false;

            // limpiar el video
            video.Reset();

            // iniciar el cpu
            cpu.Init();
        }

        /*public void EmulateFrame()
        {
            cpu.EmulateFrame();
        }*/

        public void StartProgram()
        {
            if(programLoaded)
                new Thread(new ThreadStart(cpu.Run)).Start();
        }

        public void PauseProgram()
        {
            cpu.CPUState = CPUModule.EmulationState.Paused;
            while (cpu.IsRunning) Thread.Sleep(0);
        }

        public void StopProgram()
        {
            cpu.CPUState = CPUModule.EmulationState.Stopped;
            while (cpu.IsRunning) Thread.Sleep(0);
        }

        public void LoadProgram(string programName){
            FileStream program;
            
            try
            {
                program = new FileStream(@programName, FileMode.Open);

                if (program.Length == 0)
                {
                    throw new Exception("Error loading program: File is empty or damage");
                }

                ResetHardware();
                // Comenzamos a cargar la rom a la memoria a partir de la dir 0x200
                for (uint i = 0; i < program.Length; i++)
                    ram.WriteByte(CPUModule.BEGIN_INSTRUCTION + i, (byte)program.ReadByte());

                program.Close();
                programLoaded = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading programa: " + ex.Message);
            }
        }
        #endregion
    }
}
