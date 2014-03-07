using SdlDotNet.Core; //Eventos como Teclado, FPS, etc.
using SdlDotNet.Graphics; //para Surfaces
using SdlDotNet.Graphics.Sprites;  //para Sprites y textos en pantalla
using SdlDotNet.Input; //para manejo de teclado

namespace Schip
{
    partial class SuperChip8View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperChip8View));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emuladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.depurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteInstrucciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDebug = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.st = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.TextBox();
            this.nextDebug = new System.Windows.Forms.Button();
            this.instruccion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.kk = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.ir = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.keyF = new System.Windows.Forms.CheckBox();
            this.keyA = new System.Windows.Forms.CheckBox();
            this.keyB = new System.Windows.Forms.CheckBox();
            this.keyC = new System.Windows.Forms.CheckBox();
            this.key2 = new System.Windows.Forms.CheckBox();
            this.key7 = new System.Windows.Forms.CheckBox();
            this.key1 = new System.Windows.Forms.CheckBox();
            this.key8 = new System.Windows.Forms.CheckBox();
            this.key9 = new System.Windows.Forms.CheckBox();
            this.keyD = new System.Windows.Forms.CheckBox();
            this.keyE = new System.Windows.Forms.CheckBox();
            this.key3 = new System.Windows.Forms.CheckBox();
            this.key4 = new System.Windows.Forms.CheckBox();
            this.key5 = new System.Windows.Forms.CheckBox();
            this.key6 = new System.Windows.Forms.CheckBox();
            this.key0 = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.st15 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.st14 = new System.Windows.Forms.TextBox();
            this.st13 = new System.Windows.Forms.TextBox();
            this.st12 = new System.Windows.Forms.TextBox();
            this.st11 = new System.Windows.Forms.TextBox();
            this.st10 = new System.Windows.Forms.TextBox();
            this.st9 = new System.Windows.Forms.TextBox();
            this.st8 = new System.Windows.Forms.TextBox();
            this.st7 = new System.Windows.Forms.TextBox();
            this.st6 = new System.Windows.Forms.TextBox();
            this.st5 = new System.Windows.Forms.TextBox();
            this.st4 = new System.Windows.Forms.TextBox();
            this.st3 = new System.Windows.Forms.TextBox();
            this.st2 = new System.Windows.Forms.TextBox();
            this.st1 = new System.Windows.Forms.TextBox();
            this.st0 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.v15 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v14 = new System.Windows.Forms.TextBox();
            this.v13 = new System.Windows.Forms.TextBox();
            this.v12 = new System.Windows.Forms.TextBox();
            this.v11 = new System.Windows.Forms.TextBox();
            this.v10 = new System.Windows.Forms.TextBox();
            this.v9 = new System.Windows.Forms.TextBox();
            this.v8 = new System.Windows.Forms.TextBox();
            this.v7 = new System.Windows.Forms.TextBox();
            this.v6 = new System.Windows.Forms.TextBox();
            this.v5 = new System.Windows.Forms.TextBox();
            this.v4 = new System.Windows.Forms.TextBox();
            this.v3 = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.v0 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.display = new SdlDotNet.Windows.SurfaceControl();
            this.memoryHex = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelDebug.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.emuladorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarToolStripMenuItem.Text = "&Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // emuladorToolStripMenuItem
            // 
            this.emuladorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continuarToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.depurarToolStripMenuItem,
            this.siguienteInstrucciónToolStripMenuItem});
            this.emuladorToolStripMenuItem.Name = "emuladorToolStripMenuItem";
            this.emuladorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.emuladorToolStripMenuItem.Text = "&Emulador";
            // 
            // continuarToolStripMenuItem
            // 
            this.continuarToolStripMenuItem.Enabled = false;
            this.continuarToolStripMenuItem.Name = "continuarToolStripMenuItem";
            this.continuarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.continuarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.continuarToolStripMenuItem.Text = "&Continuar";
            this.continuarToolStripMenuItem.Click += new System.EventHandler(this.continuarToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Enabled = false;
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.detenerToolStripMenuItem.Text = "&Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Enabled = false;
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.pausarToolStripMenuItem.Text = "&Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Enabled = false;
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.reiniciarToolStripMenuItem.Text = "&Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // depurarToolStripMenuItem
            // 
            this.depurarToolStripMenuItem.Enabled = false;
            this.depurarToolStripMenuItem.Name = "depurarToolStripMenuItem";
            this.depurarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.depurarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.depurarToolStripMenuItem.Text = "Depu&rar";
            this.depurarToolStripMenuItem.Click += new System.EventHandler(this.depurarToolStripMenuItem_Click);
            // 
            // siguienteInstrucciónToolStripMenuItem
            // 
            this.siguienteInstrucciónToolStripMenuItem.Enabled = false;
            this.siguienteInstrucciónToolStripMenuItem.Name = "siguienteInstrucciónToolStripMenuItem";
            this.siguienteInstrucciónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.siguienteInstrucciónToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.siguienteInstrucciónToolStripMenuItem.Text = "&Siguiente Instrucción";
            this.siguienteInstrucciónToolStripMenuItem.Click += new System.EventHandler(this.siguienteInstrucciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de..";
            // 
            // panelDebug
            // 
            this.panelDebug.Controls.Add(this.groupBox5);
            this.panelDebug.Controls.Add(this.groupBox4);
            this.panelDebug.Controls.Add(this.groupBox3);
            this.panelDebug.Controls.Add(this.groupBox2);
            this.panelDebug.Controls.Add(this.groupBox1);
            this.panelDebug.Enabled = false;
            this.panelDebug.Location = new System.Drawing.Point(0, 256);
            this.panelDebug.Margin = new System.Windows.Forms.Padding(0);
            this.panelDebug.Name = "panelDebug";
            this.panelDebug.Size = new System.Drawing.Size(512, 275);
            this.panelDebug.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.st);
            this.groupBox5.Controls.Add(this.dt);
            this.groupBox5.Controls.Add(this.nextDebug);
            this.groupBox5.Controls.Add(this.instruccion);
            this.groupBox5.Location = new System.Drawing.Point(171, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 63);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Siguiente Instrucccion, Controles y Retardos";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(86, 40);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(21, 13);
            this.label53.TabIndex = 20;
            this.label53.Text = "ST";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(8, 40);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(22, 13);
            this.label52.TabIndex = 19;
            this.label52.Text = "DT";
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(114, 37);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(45, 20);
            this.st.TabIndex = 18;
            this.st.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(35, 37);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(45, 20);
            this.dt.TabIndex = 17;
            this.dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nextDebug
            // 
            this.nextDebug.Location = new System.Drawing.Point(207, 35);
            this.nextDebug.Name = "nextDebug";
            this.nextDebug.Size = new System.Drawing.Size(131, 23);
            this.nextDebug.TabIndex = 2;
            this.nextDebug.Text = "Siguie&nte Instrucción";
            this.nextDebug.UseVisualStyleBackColor = true;
            this.nextDebug.Click += new System.EventHandler(this.nextDebug_Click);
            // 
            // instruccion
            // 
            this.instruccion.Location = new System.Drawing.Point(6, 14);
            this.instruccion.Name = "instruccion";
            this.instruccion.Size = new System.Drawing.Size(332, 20);
            this.instruccion.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.kk);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.ir);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.pc);
            this.groupBox4.Location = new System.Drawing.Point(3, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 63);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otros Registros";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(118, 17);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(21, 13);
            this.label51.TabIndex = 21;
            this.label51.Text = "KK";
            // 
            // kk
            // 
            this.kk.Location = new System.Drawing.Point(105, 31);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(45, 20);
            this.kk.TabIndex = 20;
            this.kk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(74, 17);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(10, 13);
            this.label50.TabIndex = 19;
            this.label50.Text = "I";
            // 
            // ir
            // 
            this.ir.Location = new System.Drawing.Point(55, 31);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(45, 20);
            this.ir.TabIndex = 18;
            this.ir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(18, 17);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(21, 13);
            this.label49.TabIndex = 17;
            this.label49.Text = "PC";
            // 
            // pc
            // 
            this.pc.Location = new System.Drawing.Point(5, 31);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(45, 20);
            this.pc.TabIndex = 16;
            this.pc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.keyF);
            this.groupBox3.Controls.Add(this.keyA);
            this.groupBox3.Controls.Add(this.keyB);
            this.groupBox3.Controls.Add(this.keyC);
            this.groupBox3.Controls.Add(this.key2);
            this.groupBox3.Controls.Add(this.key7);
            this.groupBox3.Controls.Add(this.key1);
            this.groupBox3.Controls.Add(this.key8);
            this.groupBox3.Controls.Add(this.key9);
            this.groupBox3.Controls.Add(this.keyD);
            this.groupBox3.Controls.Add(this.keyE);
            this.groupBox3.Controls.Add(this.key3);
            this.groupBox3.Controls.Add(this.key4);
            this.groupBox3.Controls.Add(this.key5);
            this.groupBox3.Controls.Add(this.key6);
            this.groupBox3.Controls.Add(this.key0);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Location = new System.Drawing.Point(2, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teclas Presionadas";
            // 
            // keyF
            // 
            this.keyF.AutoSize = true;
            this.keyF.Location = new System.Drawing.Point(478, 32);
            this.keyF.Name = "keyF";
            this.keyF.Size = new System.Drawing.Size(15, 14);
            this.keyF.TabIndex = 46;
            this.keyF.UseVisualStyleBackColor = true;
            // 
            // keyA
            // 
            this.keyA.AutoSize = true;
            this.keyA.Location = new System.Drawing.Point(324, 32);
            this.keyA.Name = "keyA";
            this.keyA.Size = new System.Drawing.Size(15, 14);
            this.keyA.TabIndex = 45;
            this.keyA.UseVisualStyleBackColor = true;
            // 
            // keyB
            // 
            this.keyB.AutoSize = true;
            this.keyB.Location = new System.Drawing.Point(355, 32);
            this.keyB.Name = "keyB";
            this.keyB.Size = new System.Drawing.Size(15, 14);
            this.keyB.TabIndex = 44;
            this.keyB.UseVisualStyleBackColor = true;
            // 
            // keyC
            // 
            this.keyC.AutoSize = true;
            this.keyC.Location = new System.Drawing.Point(386, 32);
            this.keyC.Name = "keyC";
            this.keyC.Size = new System.Drawing.Size(15, 14);
            this.keyC.TabIndex = 43;
            this.keyC.UseVisualStyleBackColor = true;
            // 
            // key2
            // 
            this.key2.AutoSize = true;
            this.key2.Location = new System.Drawing.Point(76, 32);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(15, 14);
            this.key2.TabIndex = 42;
            this.key2.UseVisualStyleBackColor = true;
            // 
            // key7
            // 
            this.key7.AutoSize = true;
            this.key7.Location = new System.Drawing.Point(230, 32);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(15, 14);
            this.key7.TabIndex = 41;
            this.key7.UseVisualStyleBackColor = true;
            // 
            // key1
            // 
            this.key1.AutoSize = true;
            this.key1.Location = new System.Drawing.Point(46, 32);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(15, 14);
            this.key1.TabIndex = 40;
            this.key1.UseVisualStyleBackColor = true;
            // 
            // key8
            // 
            this.key8.AutoSize = true;
            this.key8.Location = new System.Drawing.Point(261, 32);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(15, 14);
            this.key8.TabIndex = 39;
            this.key8.UseVisualStyleBackColor = true;
            // 
            // key9
            // 
            this.key9.AutoSize = true;
            this.key9.Location = new System.Drawing.Point(292, 32);
            this.key9.Name = "key9";
            this.key9.Size = new System.Drawing.Size(15, 14);
            this.key9.TabIndex = 38;
            this.key9.UseVisualStyleBackColor = true;
            // 
            // keyD
            // 
            this.keyD.AutoSize = true;
            this.keyD.Location = new System.Drawing.Point(416, 32);
            this.keyD.Name = "keyD";
            this.keyD.Size = new System.Drawing.Size(15, 14);
            this.keyD.TabIndex = 37;
            this.keyD.UseVisualStyleBackColor = true;
            // 
            // keyE
            // 
            this.keyE.AutoSize = true;
            this.keyE.Location = new System.Drawing.Point(448, 32);
            this.keyE.Name = "keyE";
            this.keyE.Size = new System.Drawing.Size(15, 14);
            this.keyE.TabIndex = 36;
            this.keyE.UseVisualStyleBackColor = true;
            // 
            // key3
            // 
            this.key3.AutoSize = true;
            this.key3.Location = new System.Drawing.Point(106, 32);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(15, 14);
            this.key3.TabIndex = 35;
            this.key3.UseVisualStyleBackColor = true;
            // 
            // key4
            // 
            this.key4.AutoSize = true;
            this.key4.Location = new System.Drawing.Point(137, 32);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(15, 14);
            this.key4.TabIndex = 34;
            this.key4.UseVisualStyleBackColor = true;
            // 
            // key5
            // 
            this.key5.AutoSize = true;
            this.key5.Location = new System.Drawing.Point(168, 32);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(15, 14);
            this.key5.TabIndex = 33;
            this.key5.UseVisualStyleBackColor = true;
            // 
            // key6
            // 
            this.key6.AutoSize = true;
            this.key6.Location = new System.Drawing.Point(199, 32);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(15, 14);
            this.key6.TabIndex = 32;
            this.key6.UseVisualStyleBackColor = true;
            // 
            // key0
            // 
            this.key0.AutoSize = true;
            this.key0.Location = new System.Drawing.Point(15, 32);
            this.key0.Name = "key0";
            this.key0.Size = new System.Drawing.Size(15, 14);
            this.key0.TabIndex = 31;
            this.key0.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(479, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 13);
            this.label33.TabIndex = 30;
            this.label33.Text = "F";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(448, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(14, 13);
            this.label34.TabIndex = 29;
            this.label34.Text = "E";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(416, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 13);
            this.label35.TabIndex = 28;
            this.label35.Text = "D";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(386, 16);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(14, 13);
            this.label36.TabIndex = 27;
            this.label36.Text = "C";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(355, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(14, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "B";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(324, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(14, 13);
            this.label38.TabIndex = 25;
            this.label38.Text = "A";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(293, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 13);
            this.label39.TabIndex = 16;
            this.label39.Text = "9";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(262, 16);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(13, 13);
            this.label40.TabIndex = 24;
            this.label40.Text = "8";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(231, 16);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(13, 13);
            this.label41.TabIndex = 23;
            this.label41.Text = "7";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(200, 16);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(13, 13);
            this.label42.TabIndex = 22;
            this.label42.Text = "6";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(169, 16);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(13, 13);
            this.label43.TabIndex = 21;
            this.label43.Text = "5";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(138, 16);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 13);
            this.label44.TabIndex = 20;
            this.label44.Text = "4";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(107, 16);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(13, 13);
            this.label45.TabIndex = 19;
            this.label45.Text = "3";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(76, 16);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(13, 13);
            this.label46.TabIndex = 18;
            this.label46.Text = "2";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(46, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(13, 13);
            this.label47.TabIndex = 17;
            this.label47.Text = "1";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(15, 16);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(13, 13);
            this.label48.TabIndex = 15;
            this.label48.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.st15);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.st14);
            this.groupBox2.Controls.Add(this.st13);
            this.groupBox2.Controls.Add(this.st12);
            this.groupBox2.Controls.Add(this.st11);
            this.groupBox2.Controls.Add(this.st10);
            this.groupBox2.Controls.Add(this.st9);
            this.groupBox2.Controls.Add(this.st8);
            this.groupBox2.Controls.Add(this.st7);
            this.groupBox2.Controls.Add(this.st6);
            this.groupBox2.Controls.Add(this.st5);
            this.groupBox2.Controls.Add(this.st4);
            this.groupBox2.Controls.Add(this.st3);
            this.groupBox2.Controls.Add(this.st2);
            this.groupBox2.Controls.Add(this.st1);
            this.groupBox2.Controls.Add(this.st0);
            this.groupBox2.Location = new System.Drawing.Point(3, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pila";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(476, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "15";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(445, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "14";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(414, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "13";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(381, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "12";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(352, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "11";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(321, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "10";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(293, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "9";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(262, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "8";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(231, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "7";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(200, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "6";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(169, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 13);
            this.label27.TabIndex = 21;
            this.label27.Text = "5";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(138, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 20;
            this.label28.Text = "4";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(107, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 13);
            this.label29.TabIndex = 19;
            this.label29.Text = "3";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(76, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 13);
            this.label30.TabIndex = 18;
            this.label30.Text = "2";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(46, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 13);
            this.label31.TabIndex = 17;
            this.label31.Text = "1";
            // 
            // st15
            // 
            this.st15.Location = new System.Drawing.Point(470, 30);
            this.st15.Name = "st15";
            this.st15.ReadOnly = true;
            this.st15.Size = new System.Drawing.Size(31, 20);
            this.st15.TabIndex = 16;
            this.st15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 13);
            this.label32.TabIndex = 15;
            this.label32.Text = "0";
            // 
            // st14
            // 
            this.st14.Location = new System.Drawing.Point(439, 30);
            this.st14.Name = "st14";
            this.st14.ReadOnly = true;
            this.st14.Size = new System.Drawing.Size(31, 20);
            this.st14.TabIndex = 14;
            this.st14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st13
            // 
            this.st13.Location = new System.Drawing.Point(408, 30);
            this.st13.Name = "st13";
            this.st13.ReadOnly = true;
            this.st13.Size = new System.Drawing.Size(31, 20);
            this.st13.TabIndex = 13;
            this.st13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st12
            // 
            this.st12.Location = new System.Drawing.Point(377, 30);
            this.st12.Name = "st12";
            this.st12.ReadOnly = true;
            this.st12.Size = new System.Drawing.Size(31, 20);
            this.st12.TabIndex = 12;
            this.st12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st11
            // 
            this.st11.Location = new System.Drawing.Point(346, 30);
            this.st11.Name = "st11";
            this.st11.ReadOnly = true;
            this.st11.Size = new System.Drawing.Size(31, 20);
            this.st11.TabIndex = 11;
            this.st11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st10
            // 
            this.st10.Location = new System.Drawing.Point(315, 30);
            this.st10.Name = "st10";
            this.st10.ReadOnly = true;
            this.st10.Size = new System.Drawing.Size(31, 20);
            this.st10.TabIndex = 10;
            this.st10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st9
            // 
            this.st9.Location = new System.Drawing.Point(284, 30);
            this.st9.Name = "st9";
            this.st9.ReadOnly = true;
            this.st9.Size = new System.Drawing.Size(31, 20);
            this.st9.TabIndex = 9;
            this.st9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st8
            // 
            this.st8.Location = new System.Drawing.Point(253, 30);
            this.st8.Name = "st8";
            this.st8.ReadOnly = true;
            this.st8.Size = new System.Drawing.Size(31, 20);
            this.st8.TabIndex = 8;
            this.st8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st7
            // 
            this.st7.Location = new System.Drawing.Point(222, 30);
            this.st7.Name = "st7";
            this.st7.ReadOnly = true;
            this.st7.Size = new System.Drawing.Size(31, 20);
            this.st7.TabIndex = 7;
            this.st7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st6
            // 
            this.st6.Location = new System.Drawing.Point(191, 30);
            this.st6.Name = "st6";
            this.st6.ReadOnly = true;
            this.st6.Size = new System.Drawing.Size(31, 20);
            this.st6.TabIndex = 6;
            this.st6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st5
            // 
            this.st5.Location = new System.Drawing.Point(160, 30);
            this.st5.Name = "st5";
            this.st5.ReadOnly = true;
            this.st5.Size = new System.Drawing.Size(31, 20);
            this.st5.TabIndex = 5;
            this.st5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st4
            // 
            this.st4.Location = new System.Drawing.Point(129, 30);
            this.st4.Name = "st4";
            this.st4.ReadOnly = true;
            this.st4.Size = new System.Drawing.Size(31, 20);
            this.st4.TabIndex = 4;
            this.st4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st3
            // 
            this.st3.Location = new System.Drawing.Point(98, 30);
            this.st3.Name = "st3";
            this.st3.ReadOnly = true;
            this.st3.Size = new System.Drawing.Size(31, 20);
            this.st3.TabIndex = 3;
            this.st3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st2
            // 
            this.st2.Location = new System.Drawing.Point(67, 30);
            this.st2.Name = "st2";
            this.st2.ReadOnly = true;
            this.st2.Size = new System.Drawing.Size(31, 20);
            this.st2.TabIndex = 2;
            this.st2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st1
            // 
            this.st1.Location = new System.Drawing.Point(36, 30);
            this.st1.Name = "st1";
            this.st1.ReadOnly = true;
            this.st1.Size = new System.Drawing.Size(31, 20);
            this.st1.TabIndex = 1;
            this.st1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // st0
            // 
            this.st0.Location = new System.Drawing.Point(5, 30);
            this.st0.Name = "st0";
            this.st0.ReadOnly = true;
            this.st0.Size = new System.Drawing.Size(31, 20);
            this.st0.TabIndex = 0;
            this.st0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.v15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.v14);
            this.groupBox1.Controls.Add(this.v13);
            this.groupBox1.Controls.Add(this.v12);
            this.groupBox1.Controls.Add(this.v11);
            this.groupBox1.Controls.Add(this.v10);
            this.groupBox1.Controls.Add(this.v9);
            this.groupBox1.Controls.Add(this.v8);
            this.groupBox1.Controls.Add(this.v7);
            this.groupBox1.Controls.Add(this.v6);
            this.groupBox1.Controls.Add(this.v5);
            this.groupBox1.Controls.Add(this.v4);
            this.groupBox1.Controls.Add(this.v3);
            this.groupBox1.Controls.Add(this.v2);
            this.groupBox1.Controls.Add(this.v1);
            this.groupBox1.Controls.Add(this.v0);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vector V";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(476, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "1";
            // 
            // v15
            // 
            this.v15.Location = new System.Drawing.Point(470, 30);
            this.v15.Name = "v15";
            this.v15.Size = new System.Drawing.Size(31, 20);
            this.v15.TabIndex = 16;
            this.v15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "0";
            // 
            // v14
            // 
            this.v14.Location = new System.Drawing.Point(439, 30);
            this.v14.Name = "v14";
            this.v14.Size = new System.Drawing.Size(31, 20);
            this.v14.TabIndex = 14;
            this.v14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v13
            // 
            this.v13.Location = new System.Drawing.Point(408, 30);
            this.v13.Name = "v13";
            this.v13.Size = new System.Drawing.Size(31, 20);
            this.v13.TabIndex = 13;
            this.v13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v12
            // 
            this.v12.Location = new System.Drawing.Point(377, 30);
            this.v12.Name = "v12";
            this.v12.Size = new System.Drawing.Size(31, 20);
            this.v12.TabIndex = 12;
            this.v12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v11
            // 
            this.v11.Location = new System.Drawing.Point(346, 30);
            this.v11.Name = "v11";
            this.v11.Size = new System.Drawing.Size(31, 20);
            this.v11.TabIndex = 11;
            this.v11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v10
            // 
            this.v10.Location = new System.Drawing.Point(315, 30);
            this.v10.Name = "v10";
            this.v10.Size = new System.Drawing.Size(31, 20);
            this.v10.TabIndex = 10;
            this.v10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v9
            // 
            this.v9.Location = new System.Drawing.Point(284, 30);
            this.v9.Name = "v9";
            this.v9.Size = new System.Drawing.Size(31, 20);
            this.v9.TabIndex = 9;
            this.v9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v8
            // 
            this.v8.Location = new System.Drawing.Point(253, 30);
            this.v8.Name = "v8";
            this.v8.Size = new System.Drawing.Size(31, 20);
            this.v8.TabIndex = 8;
            this.v8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v7
            // 
            this.v7.Location = new System.Drawing.Point(222, 30);
            this.v7.Name = "v7";
            this.v7.Size = new System.Drawing.Size(31, 20);
            this.v7.TabIndex = 7;
            this.v7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v6
            // 
            this.v6.Location = new System.Drawing.Point(191, 30);
            this.v6.Name = "v6";
            this.v6.Size = new System.Drawing.Size(31, 20);
            this.v6.TabIndex = 6;
            this.v6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v5
            // 
            this.v5.Location = new System.Drawing.Point(160, 30);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(31, 20);
            this.v5.TabIndex = 5;
            this.v5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v4
            // 
            this.v4.Location = new System.Drawing.Point(129, 30);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(31, 20);
            this.v4.TabIndex = 4;
            this.v4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v3
            // 
            this.v3.Location = new System.Drawing.Point(98, 30);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(31, 20);
            this.v3.TabIndex = 3;
            this.v3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(67, 30);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(31, 20);
            this.v2.TabIndex = 2;
            this.v2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(36, 30);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(31, 20);
            this.v1.TabIndex = 1;
            this.v1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // v0
            // 
            this.v0.Location = new System.Drawing.Point(5, 30);
            this.v0.Name = "v0";
            this.v0.Size = new System.Drawing.Size(31, 20);
            this.v0.TabIndex = 0;
            this.v0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.display);
            this.splitContainer1.Panel1.Controls.Add(this.panelDebug);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.memoryHex);
            this.splitContainer1.Size = new System.Drawing.Size(864, 531);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.TabIndex = 3;
            // 
            // display
            // 
            this.display.AccessibleDescription = "SdlDotNet SurfaceControl";
            this.display.AccessibleName = "SurfaceControl";
            this.display.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.display.BackColor = System.Drawing.Color.Black;
            this.display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.display.Image = ((System.Drawing.Image)(resources.GetObject("display.Image")));
            this.display.InitialImage = null;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Margin = new System.Windows.Forms.Padding(0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(512, 256);
            this.display.TabIndex = 2;
            this.display.TabStop = false;
            // 
            // memoryHex
            // 
            this.memoryHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryHex.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryHex.Location = new System.Drawing.Point(0, 0);
            this.memoryHex.Multiline = true;
            this.memoryHex.Name = "memoryHex";
            this.memoryHex.ReadOnly = true;
            this.memoryHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memoryHex.Size = new System.Drawing.Size(348, 531);
            this.memoryHex.TabIndex = 0;
            // 
            // SuperChip8View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(866, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SuperChip8View";
            this.Text = "SuperChip8View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SuperChip8View_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDebug.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emuladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel panelDebug;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem depurarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox v14;
        private System.Windows.Forms.TextBox v13;
        private System.Windows.Forms.TextBox v12;
        private System.Windows.Forms.TextBox v11;
        private System.Windows.Forms.TextBox v10;
        private System.Windows.Forms.TextBox v9;
        private System.Windows.Forms.TextBox v8;
        private System.Windows.Forms.TextBox v7;
        private System.Windows.Forms.TextBox v6;
        private System.Windows.Forms.TextBox v5;
        private System.Windows.Forms.TextBox v4;
        private System.Windows.Forms.TextBox v3;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.TextBox v0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox v15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox st15;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox st14;
        private System.Windows.Forms.TextBox st13;
        private System.Windows.Forms.TextBox st12;
        private System.Windows.Forms.TextBox st11;
        private System.Windows.Forms.TextBox st10;
        private System.Windows.Forms.TextBox st9;
        private System.Windows.Forms.TextBox st8;
        private System.Windows.Forms.TextBox st7;
        private System.Windows.Forms.TextBox st6;
        private System.Windows.Forms.TextBox st5;
        private System.Windows.Forms.TextBox st4;
        private System.Windows.Forms.TextBox st3;
        private System.Windows.Forms.TextBox st2;
        private System.Windows.Forms.TextBox st1;
        private System.Windows.Forms.TextBox st0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.CheckBox keyF;
        private System.Windows.Forms.CheckBox keyA;
        private System.Windows.Forms.CheckBox keyB;
        private System.Windows.Forms.CheckBox keyC;
        private System.Windows.Forms.CheckBox key2;
        private System.Windows.Forms.CheckBox key7;
        private System.Windows.Forms.CheckBox key1;
        private System.Windows.Forms.CheckBox key8;
        private System.Windows.Forms.CheckBox key9;
        private System.Windows.Forms.CheckBox keyD;
        private System.Windows.Forms.CheckBox keyE;
        private System.Windows.Forms.CheckBox key3;
        private System.Windows.Forms.CheckBox key4;
        private System.Windows.Forms.CheckBox key5;
        private System.Windows.Forms.CheckBox key6;
        private System.Windows.Forms.CheckBox key0;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox kk;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox ir;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox pc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox instruccion;
        private System.Windows.Forms.ToolStripMenuItem siguienteInstrucciónToolStripMenuItem;
        private System.Windows.Forms.Button nextDebug;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SdlDotNet.Windows.SurfaceControl display;
        private System.Windows.Forms.TextBox memoryHex;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox dt;
    }
}