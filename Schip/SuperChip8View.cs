using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SdlDotNet.Core; //Eventos como Teclado, FPS, etc.
using SdlDotNet.Graphics; //para Surfaces
using SdlDotNet.Graphics.Sprites;  //para Sprites y textos en pantalla
using SdlDotNet.Input; //para manejo de teclado
using System.Threading;

namespace Schip
{
    public partial class SuperChip8View : Form
    {
        #region Constantes para mapear las teclas del emulador
        private static readonly int KEY_D1 = SchipMachine.Keyboard[0];
        private static readonly int KEY_D2 = SchipMachine.Keyboard[1];
        private static readonly int KEY_D3 = SchipMachine.Keyboard[2];
        private static readonly int KEY_D4 = SchipMachine.Keyboard[3];
        private static readonly int KEY_Q = SchipMachine.Keyboard[4];
        private static readonly int KEY_W = SchipMachine.Keyboard[5];
        private static readonly int KEY_E = SchipMachine.Keyboard[6];
        private static readonly int KEY_R = SchipMachine.Keyboard[7];
        private static readonly int KEY_A = SchipMachine.Keyboard[8];
        private static readonly int KEY_S = SchipMachine.Keyboard[9];
        private static readonly int KEY_D = SchipMachine.Keyboard[10];
        private static readonly int KEY_F = SchipMachine.Keyboard[11];
        private static readonly int KEY_Z = SchipMachine.Keyboard[12];
        private static readonly int KEY_X = SchipMachine.Keyboard[13];
        private static readonly int KEY_C = SchipMachine.Keyboard[14];
        private static readonly int KEY_V = SchipMachine.Keyboard[15];
        #endregion

        private enum MachineState {Paused, Running, Stopped, Debugging};

        #region atributos
        private SchipMachine machine;
        private MachineState state;
        private string programName;
        #endregion

        #region atributos para la depuracion
        private Disassembler disassembler;
        private TextBox[] vControls;
        private TextBox[] stackControls;
        private CheckBox[] keysControls;
        #endregion

        public SuperChip8View()
        {
            InitializeComponent();
            Video.Initialize();

            this.Text = "Emulador SChip-8";         
            
            machine = new SchipMachine();
            machine.Cpu.UpdateDisplay = this.UpdateDisplay;
            disassembler = new Disassembler(machine);
            state = MachineState.Stopped;
            //SdlDotNet.Core.Events.Fps = 60;
            //SdlDotNet.Core.Events.Tick += new EventHandler<TickEventArgs>(Events_Tick);
            this.KeyDown += new KeyEventHandler(this.Tecla_Presionada);
            this.KeyUp += new KeyEventHandler(this.Tecla_Liberada);

            //Inicializar los controles de depuracion
            vControls = new TextBox[] { v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15 };
            stackControls = new TextBox[] { st0, st1, st2, st3, st4, st5, st6, st7, st8, st9, st10, st11, st12, st13, st14, st15 };
            keysControls = new CheckBox[] { key0, key1, key2, key3, key4, key5, key6, key7, key8, key9, keyA, keyB, keyC, keyD, keyE, keyF };
        }

        /*private void Events_Tick(object sender, TickEventArgs e)
        {
            this.Text = "Emulador SChip-8  FPS: " + SdlDotNet.Core.Events.Fps;
            if (state == MachineState.Running)
            {
                try
                {
                    machine.EmulateFrame();
                    //UpdateDisplay();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    state = MachineState.Paused;
                    ToggleMachineStateMenuItems();
                }
            }
        }*/

        private void Tecla_Presionada(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: machine.Keys[KEY_D1] = true; break;
                case Keys.D2: machine.Keys[KEY_D2] = true; break;
                case Keys.D3: machine.Keys[KEY_D3] = true; break;
                case Keys.D4: machine.Keys[KEY_D4] = true; break;
                case Keys.Q: machine.Keys[KEY_Q] = true; break;
                case Keys.W: machine.Keys[KEY_W] = true; break;
                case Keys.E: machine.Keys[KEY_E] = true; break;
                case Keys.R: machine.Keys[KEY_R] = true; break;
                case Keys.A: machine.Keys[KEY_A] = true; break;
                case Keys.S: machine.Keys[KEY_S] = true; break;
                case Keys.D: machine.Keys[KEY_D] = true; break;
                case Keys.F: machine.Keys[KEY_F] = true; break;
                case Keys.Z: machine.Keys[KEY_Z] = true; break;
                case Keys.X: machine.Keys[KEY_X] = true; break;
                case Keys.C: machine.Keys[KEY_C] = true; break;
                case Keys.V: machine.Keys[KEY_V] = true; break;
            }
        }

        private void Tecla_Liberada(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: machine.Keys[KEY_D1] = false; break;
                case Keys.D2: machine.Keys[KEY_D2] = false; break;
                case Keys.D3: machine.Keys[KEY_D3] = false; break;
                case Keys.D4: machine.Keys[KEY_D4] = false; break;
                case Keys.Q: machine.Keys[KEY_Q] = false; break;
                case Keys.W: machine.Keys[KEY_W] = false; break;
                case Keys.E: machine.Keys[KEY_E] = false; break;
                case Keys.R: machine.Keys[KEY_R] = false; break;
                case Keys.A: machine.Keys[KEY_A] = false; break;
                case Keys.S: machine.Keys[KEY_S] = false; break;
                case Keys.D: machine.Keys[KEY_D] = false; break;
                case Keys.F: machine.Keys[KEY_F] = false; break;
                case Keys.Z: machine.Keys[KEY_Z] = false; break;
                case Keys.X: machine.Keys[KEY_X] = false; break;
                case Keys.C: machine.Keys[KEY_C] = false; break;
                case Keys.V: machine.Keys[KEY_V] = false; break;
            }
        }

        public void UpdateDisplay() {
            
            VideoLine128[] displayBuffer = machine.Video.Display;
            int pixelSizeX = display.Width / machine.Video.CurrentHorzRes;
            int pixelSizeY = display.Height / machine.Video.CurrentVertRes;
            Surface whitePixel = Video.CreateRgbSurface(pixelSizeX, pixelSizeY);
            Surface surfaceOut = Video.CreateRgbSurface(display.Width, display.Height);

            whitePixel.Fill(Color.White);
            surfaceOut.Fill(Color.Black);

            for (int i = 0; i < machine.Video.CurrentVertRes; i++)
            {
                for (int j = 0; j < machine.Video.CurrentHorzRes; j++)
                {
                    if (displayBuffer[i].IsPixelActive(j))
                        surfaceOut.Blit(whitePixel, new Point(j * pixelSizeX, i * pixelSizeY));
                }
            }
            surfaceOut.Update();

            display.Invoke( new Action(() => { display.Blit(surfaceOut); }));
            display.Invoke(new Action(() => { display.Update(); }));
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                programName = openFileDialog.FileName;
                ResetSoftware();
                //SdlDotNet.Core.Events.Run();
            }
        }

        private void ResetSoftware()
        {
            machine.LoadProgram(programName);
            state = MachineState.Running;
            machine.StartProgram();
            ToggleMachineStateMenuItems();
            memoryHex.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarAplicacion();
        }

        void CerrarAplicacion()
        {
            SdlDotNet.Core.Events.Close();
            SdlDotNet.Core.Events.QuitApplication();
            machine.StopProgram();
            Thread.Sleep(0);
            Application.Exit();
        }

        private void SuperChip8View_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarAplicacion();
        }

        private void continuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == MachineState.Stopped)
                ResetSoftware();
            else
            {
                machine.StartProgram();
                state = MachineState.Running;
                ToggleMachineStateMenuItems();
            }
        }

        private void ToggleMachineStateMenuItems()
        {
            continuarToolStripMenuItem.Enabled = state != MachineState.Running;
            pausarToolStripMenuItem.Enabled = state == MachineState.Running;
            detenerToolStripMenuItem.Enabled = pausarToolStripMenuItem.Enabled;
            reiniciarToolStripMenuItem.Enabled = state != MachineState.Stopped && state != MachineState.Debugging;
            depurarToolStripMenuItem.Enabled = state != MachineState.Stopped;
            siguienteInstrucciónToolStripMenuItem.Enabled = state == MachineState.Debugging;
            panelDebug.Enabled = state == MachineState.Debugging;
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = MachineState.Stopped;
            machine.StopProgram();
            ToggleMachineStateMenuItems();
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = MachineState.Paused;
            machine.PauseProgram();
            ToggleMachineStateMenuItems();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSoftware();
        }

        private void depurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginDebug();
        }

        private void BeginDebug()
        {
            state = MachineState.Debugging;

            machine.LoadProgram(programName);
            ToggleMachineStateMenuItems();
            
            ShowDebugMachineState(false);
        }

        private void siguienteInstrucciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugNext();
        }

        private void DebugNext() {
            machine.Cpu.EmulateInstruction();
            ShowDebugMachineState(true);
        }

        private void nextDebug_Click(object sender, EventArgs e)
        {
            DebugNext();
        }

        private void ShowDebugMachineState(bool remarkChanges)
        {
            for (int i = 0; i < vControls.Length; i++)
            {
                string value = machine.Cpu.V[i].ToString();
                vControls[i].ForeColor = remarkChanges && value.CompareTo(vControls[i].Text) != 0 ? Color.Red : Color.Black;
                vControls[i].Text = value;
            }

            for (int i = 0; i < stackControls.Length; i++)
            {
                if (i < machine.Cpu.Stack.Size)
                {
                    string value = machine.Cpu.Stack.lookAt(i).ToString();
                    stackControls[i].ForeColor = remarkChanges && stackControls[i].Text.CompareTo("") == 0 ? Color.Red : Color.Black;
                    stackControls[i].Text = value;
                }
                else
                {
                    stackControls[i].ForeColor = remarkChanges && stackControls[i].Text.CompareTo("") != 0 ? Color.Red : Color.Black;
                    stackControls[i].Text = "";
                }
            }

            for (int i = 0; i < keysControls.Length; i++)
                keysControls[i].Checked = machine.Keys[i];

            pc.ForeColor = remarkChanges && Int16.Parse(pc.Text) != machine.Cpu.Pc ? Color.Red : Color.Black;
            pc.Text = machine.Cpu.Pc.ToString();
            ir.ForeColor = remarkChanges && Int16.Parse(ir.Text) != machine.Cpu.I ? Color.Red : Color.Black;
            ir.Text = machine.Cpu.I.ToString();
            kk.ForeColor = remarkChanges && Int16.Parse(pc.Text) != machine.Cpu.KK ? Color.Red : Color.Black;
            kk.Text = machine.Cpu.KK.ToString();
            dt.ForeColor = remarkChanges && Int16.Parse(dt.Text) != machine.Cpu.DelayTimer ? Color.Red : Color.Black;
            dt.Text = machine.Cpu.DelayTimer.ToString();
            st.ForeColor = remarkChanges && Int16.Parse(st.Text) != machine.Cpu.SoundTimer ? Color.Red : Color.Black;
            st.Text = machine.Cpu.SoundTimer.ToString();
            
            instruccion.Text = disassembler.DecodeInstruction();
            FillMemoryText();
        }

        private void FillMemoryText()
        {
            StringBuilder memoryText =  new StringBuilder();;
            uint i=0;
            
            while(i < SchipMachine.RAM_SIZE){
                string line = Convert.ToString(i, 16).PadLeft(4, '0').ToUpper()+":";
                for (int j = 0; j < 16 && i<SchipMachine.RAM_SIZE; j++, i++) {
                    line += " " + Convert.ToString(machine.Ram.ReadByte(i), 16).PadLeft(2, '0').ToUpper();
                }
                memoryText.AppendLine(line);
            }
            memoryHex.Text = memoryText.ToString();
        }
    }
}
