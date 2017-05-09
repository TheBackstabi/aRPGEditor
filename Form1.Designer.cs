namespace aRPGEditor
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LOC_enUS = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_ProjLoc = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pan_Spells = new System.Windows.Forms.Panel();
            this.SPL_btn_Create = new System.Windows.Forms.Button();
            this.SPL_btn_Reset = new System.Windows.Forms.Button();
            this.SPL_btn_Apply = new System.Windows.Forms.Button();
            this.SPL_radius = new System.Windows.Forms.NumericUpDown();
            this.SPL_ticks = new System.Windows.Forms.NumericUpDown();
            this.SPL_duration = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SPL_rad_Instant = new System.Windows.Forms.RadioButton();
            this.SPL_rad_AoEDoT = new System.Windows.Forms.RadioButton();
            this.SPL_rad_AoE = new System.Windows.Forms.RadioButton();
            this.SPL_rad_DoT = new System.Windows.Forms.RadioButton();
            this.SPL_School = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SPL_Gameobj = new System.Windows.Forms.ComboBox();
            this.SPL_noGCD = new System.Windows.Forms.ComboBox();
            this.SPL_cooldown = new System.Windows.Forms.NumericUpDown();
            this.SPL_Texture = new System.Windows.Forms.ComboBox();
            this.SPL_Range = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.SPL_Potency = new System.Windows.Forms.NumericUpDown();
            this.SPL_Cost = new System.Windows.Forms.NumericUpDown();
            this.SPL_Desc = new System.Windows.Forms.TextBox();
            this.SPL_Name = new System.Windows.Forms.TextBox();
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
            this.lst_Spells = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AUR_texture = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.AUR_Mods = new System.Windows.Forms.ListBox();
            this.AUR_isDebuff = new System.Windows.Forms.ComboBox();
            this.AUR_oneUse = new System.Windows.Forms.ComboBox();
            this.AUR_Duration = new System.Windows.Forms.NumericUpDown();
            this.AUR_Desc = new System.Windows.Forms.TextBox();
            this.AUR_Name = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lst_Auras = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lst_Textures = new System.Windows.Forms.ListBox();
            this.txt_ProjectLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pan_Spells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_ticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_duration)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_cooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Potency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Cost)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUR_Duration)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LOC_enUS);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.btn_ProjLoc);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.txt_ProjectLoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 561);
            this.panel1.TabIndex = 0;
            // 
            // btn_LOC_enUS
            // 
            this.btn_LOC_enUS.Location = new System.Drawing.Point(56, 25);
            this.btn_LOC_enUS.Name = "btn_LOC_enUS";
            this.btn_LOC_enUS.Size = new System.Drawing.Size(75, 23);
            this.btn_LOC_enUS.TabIndex = 4;
            this.btn_LOC_enUS.Text = "enUS";
            this.btn_LOC_enUS.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(7, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Locale:";
            // 
            // btn_ProjLoc
            // 
            this.btn_ProjLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProjLoc.Location = new System.Drawing.Point(846, 3);
            this.btn_ProjLoc.Name = "btn_ProjLoc";
            this.btn_ProjLoc.Size = new System.Drawing.Size(36, 20);
            this.btn_ProjLoc.TabIndex = 2;
            this.btn_ProjLoc.Text = "...";
            this.btn_ProjLoc.UseVisualStyleBackColor = true;
            this.btn_ProjLoc.Click += new System.EventHandler(this.btn_ProjLoc_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.pan_Spells);
            this.tabPage1.Controls.Add(this.lst_Spells);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spells";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pan_Spells
            // 
            this.pan_Spells.AutoScroll = true;
            this.pan_Spells.Controls.Add(this.SPL_btn_Create);
            this.pan_Spells.Controls.Add(this.SPL_btn_Reset);
            this.pan_Spells.Controls.Add(this.SPL_btn_Apply);
            this.pan_Spells.Controls.Add(this.SPL_radius);
            this.pan_Spells.Controls.Add(this.SPL_ticks);
            this.pan_Spells.Controls.Add(this.SPL_duration);
            this.pan_Spells.Controls.Add(this.label25);
            this.pan_Spells.Controls.Add(this.label24);
            this.pan_Spells.Controls.Add(this.label23);
            this.pan_Spells.Controls.Add(this.groupBox1);
            this.pan_Spells.Controls.Add(this.SPL_School);
            this.pan_Spells.Controls.Add(this.label13);
            this.pan_Spells.Controls.Add(this.SPL_Gameobj);
            this.pan_Spells.Controls.Add(this.SPL_noGCD);
            this.pan_Spells.Controls.Add(this.SPL_cooldown);
            this.pan_Spells.Controls.Add(this.SPL_Texture);
            this.pan_Spells.Controls.Add(this.SPL_Range);
            this.pan_Spells.Controls.Add(this.label12);
            this.pan_Spells.Controls.Add(this.SPL_Potency);
            this.pan_Spells.Controls.Add(this.SPL_Cost);
            this.pan_Spells.Controls.Add(this.SPL_Desc);
            this.pan_Spells.Controls.Add(this.SPL_Name);
            this.pan_Spells.Controls.Add(this.label11);
            this.pan_Spells.Controls.Add(this.label10);
            this.pan_Spells.Controls.Add(this.label9);
            this.pan_Spells.Controls.Add(this.label8);
            this.pan_Spells.Controls.Add(this.label7);
            this.pan_Spells.Controls.Add(this.label6);
            this.pan_Spells.Controls.Add(this.label5);
            this.pan_Spells.Controls.Add(this.label4);
            this.pan_Spells.Controls.Add(this.label3);
            this.pan_Spells.Controls.Add(this.label2);
            this.pan_Spells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Spells.Location = new System.Drawing.Point(203, 3);
            this.pan_Spells.Name = "pan_Spells";
            this.pan_Spells.Size = new System.Drawing.Size(676, 470);
            this.pan_Spells.TabIndex = 0;
            // 
            // SPL_btn_Create
            // 
            this.SPL_btn_Create.Location = new System.Drawing.Point(169, 3);
            this.SPL_btn_Create.Name = "SPL_btn_Create";
            this.SPL_btn_Create.Size = new System.Drawing.Size(75, 36);
            this.SPL_btn_Create.TabIndex = 54;
            this.SPL_btn_Create.Text = "Create";
            this.SPL_btn_Create.UseVisualStyleBackColor = true;
            this.SPL_btn_Create.Click += new System.EventHandler(this.SPL_btn_Create_Click);
            // 
            // SPL_btn_Reset
            // 
            this.SPL_btn_Reset.Location = new System.Drawing.Point(7, 3);
            this.SPL_btn_Reset.Name = "SPL_btn_Reset";
            this.SPL_btn_Reset.Size = new System.Drawing.Size(75, 36);
            this.SPL_btn_Reset.TabIndex = 53;
            this.SPL_btn_Reset.Text = "Reset";
            this.SPL_btn_Reset.UseVisualStyleBackColor = true;
            this.SPL_btn_Reset.Click += new System.EventHandler(this.SPL_btn_Reset_Click);
            // 
            // SPL_btn_Apply
            // 
            this.SPL_btn_Apply.Location = new System.Drawing.Point(88, 3);
            this.SPL_btn_Apply.Name = "SPL_btn_Apply";
            this.SPL_btn_Apply.Size = new System.Drawing.Size(75, 36);
            this.SPL_btn_Apply.TabIndex = 52;
            this.SPL_btn_Apply.Text = "Apply";
            this.SPL_btn_Apply.UseVisualStyleBackColor = true;
            this.SPL_btn_Apply.Click += new System.EventHandler(this.SPL_btn_Apply_Click);
            // 
            // SPL_radius
            // 
            this.SPL_radius.Location = new System.Drawing.Point(460, 559);
            this.SPL_radius.Name = "SPL_radius";
            this.SPL_radius.Size = new System.Drawing.Size(120, 20);
            this.SPL_radius.TabIndex = 51;
            // 
            // SPL_ticks
            // 
            this.SPL_ticks.Location = new System.Drawing.Point(460, 524);
            this.SPL_ticks.Name = "SPL_ticks";
            this.SPL_ticks.Size = new System.Drawing.Size(120, 20);
            this.SPL_ticks.TabIndex = 50;
            // 
            // SPL_duration
            // 
            this.SPL_duration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SPL_duration.Location = new System.Drawing.Point(460, 491);
            this.SPL_duration.Name = "SPL_duration";
            this.SPL_duration.Size = new System.Drawing.Size(120, 20);
            this.SPL_duration.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(413, 561);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 48;
            this.label25.Text = "Radius";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(420, 526);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 47;
            this.label24.Text = "Ticks";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(406, 491);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Duration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SPL_rad_Instant);
            this.groupBox1.Controls.Add(this.SPL_rad_AoEDoT);
            this.groupBox1.Controls.Add(this.SPL_rad_AoE);
            this.groupBox1.Controls.Add(this.SPL_rad_DoT);
            this.groupBox1.Location = new System.Drawing.Point(31, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 61);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spell Type";
            // 
            // SPL_rad_Instant
            // 
            this.SPL_rad_Instant.AutoSize = true;
            this.SPL_rad_Instant.Location = new System.Drawing.Point(251, 25);
            this.SPL_rad_Instant.Name = "SPL_rad_Instant";
            this.SPL_rad_Instant.Size = new System.Drawing.Size(57, 17);
            this.SPL_rad_Instant.TabIndex = 3;
            this.SPL_rad_Instant.TabStop = true;
            this.SPL_rad_Instant.Text = "Instant";
            this.SPL_rad_Instant.UseVisualStyleBackColor = true;
            this.SPL_rad_Instant.CheckedChanged += new System.EventHandler(this.SPL_radioButtonChanged);
            // 
            // SPL_rad_AoEDoT
            // 
            this.SPL_rad_AoEDoT.AutoSize = true;
            this.SPL_rad_AoEDoT.Location = new System.Drawing.Point(158, 25);
            this.SPL_rad_AoEDoT.Name = "SPL_rad_AoEDoT";
            this.SPL_rad_AoEDoT.Size = new System.Drawing.Size(66, 17);
            this.SPL_rad_AoEDoT.TabIndex = 2;
            this.SPL_rad_AoEDoT.TabStop = true;
            this.SPL_rad_AoEDoT.Text = "AoEDoT";
            this.SPL_rad_AoEDoT.UseVisualStyleBackColor = true;
            this.SPL_rad_AoEDoT.CheckedChanged += new System.EventHandler(this.SPL_radioButtonChanged);
            // 
            // SPL_rad_AoE
            // 
            this.SPL_rad_AoE.AutoSize = true;
            this.SPL_rad_AoE.Location = new System.Drawing.Point(98, 25);
            this.SPL_rad_AoE.Name = "SPL_rad_AoE";
            this.SPL_rad_AoE.Size = new System.Drawing.Size(45, 17);
            this.SPL_rad_AoE.TabIndex = 1;
            this.SPL_rad_AoE.TabStop = true;
            this.SPL_rad_AoE.Text = "AoE";
            this.SPL_rad_AoE.UseVisualStyleBackColor = true;
            this.SPL_rad_AoE.CheckedChanged += new System.EventHandler(this.SPL_radioButtonChanged);
            // 
            // SPL_rad_DoT
            // 
            this.SPL_rad_DoT.AutoSize = true;
            this.SPL_rad_DoT.Location = new System.Drawing.Point(40, 25);
            this.SPL_rad_DoT.Name = "SPL_rad_DoT";
            this.SPL_rad_DoT.Size = new System.Drawing.Size(46, 17);
            this.SPL_rad_DoT.TabIndex = 0;
            this.SPL_rad_DoT.TabStop = true;
            this.SPL_rad_DoT.Text = "DoT";
            this.SPL_rad_DoT.UseVisualStyleBackColor = true;
            this.SPL_rad_DoT.CheckedChanged += new System.EventHandler(this.SPL_radioButtonChanged);
            // 
            // SPL_School
            // 
            this.SPL_School.FormattingEnabled = true;
            this.SPL_School.Items.AddRange(new object[] {
            "0",
            "1"});
            this.SPL_School.Location = new System.Drawing.Point(103, 404);
            this.SPL_School.Name = "SPL_School";
            this.SPL_School.Size = new System.Drawing.Size(121, 21);
            this.SPL_School.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Seconds";
            // 
            // SPL_Gameobj
            // 
            this.SPL_Gameobj.FormattingEnabled = true;
            this.SPL_Gameobj.Location = new System.Drawing.Point(103, 444);
            this.SPL_Gameobj.Name = "SPL_Gameobj";
            this.SPL_Gameobj.Size = new System.Drawing.Size(533, 21);
            this.SPL_Gameobj.TabIndex = 42;
            // 
            // SPL_noGCD
            // 
            this.SPL_noGCD.FormattingEnabled = true;
            this.SPL_noGCD.Items.AddRange(new object[] {
            "true",
            "false"});
            this.SPL_noGCD.Location = new System.Drawing.Point(103, 364);
            this.SPL_noGCD.Name = "SPL_noGCD";
            this.SPL_noGCD.Size = new System.Drawing.Size(120, 21);
            this.SPL_noGCD.TabIndex = 41;
            // 
            // SPL_cooldown
            // 
            this.SPL_cooldown.Location = new System.Drawing.Point(103, 324);
            this.SPL_cooldown.Name = "SPL_cooldown";
            this.SPL_cooldown.Size = new System.Drawing.Size(105, 20);
            this.SPL_cooldown.TabIndex = 40;
            // 
            // SPL_Texture
            // 
            this.SPL_Texture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SPL_Texture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SPL_Texture.FormattingEnabled = true;
            this.SPL_Texture.Location = new System.Drawing.Point(103, 284);
            this.SPL_Texture.Name = "SPL_Texture";
            this.SPL_Texture.Size = new System.Drawing.Size(533, 21);
            this.SPL_Texture.TabIndex = 39;
            // 
            // SPL_Range
            // 
            this.SPL_Range.Location = new System.Drawing.Point(103, 244);
            this.SPL_Range.Name = "SPL_Range";
            this.SPL_Range.Size = new System.Drawing.Size(105, 20);
            this.SPL_Range.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 206);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "00";
            // 
            // SPL_Potency
            // 
            this.SPL_Potency.Location = new System.Drawing.Point(103, 204);
            this.SPL_Potency.Name = "SPL_Potency";
            this.SPL_Potency.Size = new System.Drawing.Size(105, 20);
            this.SPL_Potency.TabIndex = 36;
            // 
            // SPL_Cost
            // 
            this.SPL_Cost.Location = new System.Drawing.Point(103, 164);
            this.SPL_Cost.Name = "SPL_Cost";
            this.SPL_Cost.Size = new System.Drawing.Size(105, 20);
            this.SPL_Cost.TabIndex = 35;
            // 
            // SPL_Desc
            // 
            this.SPL_Desc.Location = new System.Drawing.Point(103, 94);
            this.SPL_Desc.Multiline = true;
            this.SPL_Desc.Name = "SPL_Desc";
            this.SPL_Desc.Size = new System.Drawing.Size(533, 54);
            this.SPL_Desc.TabIndex = 34;
            // 
            // SPL_Name
            // 
            this.SPL_Name.Location = new System.Drawing.Point(103, 54);
            this.SPL_Name.Name = "SPL_Name";
            this.SPL_Name.Size = new System.Drawing.Size(533, 20);
            this.SPL_Name.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Game Object";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Spell School";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ignores GCD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cooldown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Texture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Potency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mana Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // lst_Spells
            // 
            this.lst_Spells.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_Spells.FormattingEnabled = true;
            this.lst_Spells.Location = new System.Drawing.Point(3, 3);
            this.lst_Spells.Name = "lst_Spells";
            this.lst_Spells.Size = new System.Drawing.Size(200, 470);
            this.lst_Spells.TabIndex = 0;
            this.lst_Spells.SelectedIndexChanged += new System.EventHandler(this.lst_Spells_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lst_Auras);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AUR_texture);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.AUR_Mods);
            this.panel2.Controls.Add(this.AUR_isDebuff);
            this.panel2.Controls.Add(this.AUR_oneUse);
            this.panel2.Controls.Add(this.AUR_Duration);
            this.panel2.Controls.Add(this.AUR_Desc);
            this.panel2.Controls.Add(this.AUR_Name);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 470);
            this.panel2.TabIndex = 1;
            // 
            // AUR_texture
            // 
            this.AUR_texture.FormattingEnabled = true;
            this.AUR_texture.Location = new System.Drawing.Point(110, 283);
            this.AUR_texture.Name = "AUR_texture";
            this.AUR_texture.Size = new System.Drawing.Size(532, 21);
            this.AUR_texture.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(233, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Seconds";
            // 
            // AUR_Mods
            // 
            this.AUR_Mods.FormattingEnabled = true;
            this.AUR_Mods.Location = new System.Drawing.Point(110, 321);
            this.AUR_Mods.MultiColumn = true;
            this.AUR_Mods.Name = "AUR_Mods";
            this.AUR_Mods.Size = new System.Drawing.Size(532, 95);
            this.AUR_Mods.TabIndex = 13;
            this.AUR_Mods.DoubleClick += new System.EventHandler(this.AUR_Modifiers_DoubleClick);
            // 
            // AUR_isDebuff
            // 
            this.AUR_isDebuff.FormattingEnabled = true;
            this.AUR_isDebuff.Items.AddRange(new object[] {
            "true",
            "false"});
            this.AUR_isDebuff.Location = new System.Drawing.Point(110, 245);
            this.AUR_isDebuff.Name = "AUR_isDebuff";
            this.AUR_isDebuff.Size = new System.Drawing.Size(121, 21);
            this.AUR_isDebuff.TabIndex = 11;
            // 
            // AUR_oneUse
            // 
            this.AUR_oneUse.FormattingEnabled = true;
            this.AUR_oneUse.Items.AddRange(new object[] {
            "true",
            "false"});
            this.AUR_oneUse.Location = new System.Drawing.Point(110, 207);
            this.AUR_oneUse.Name = "AUR_oneUse";
            this.AUR_oneUse.Size = new System.Drawing.Size(121, 21);
            this.AUR_oneUse.TabIndex = 10;
            // 
            // AUR_Duration
            // 
            this.AUR_Duration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AUR_Duration.Location = new System.Drawing.Point(110, 169);
            this.AUR_Duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.AUR_Duration.Name = "AUR_Duration";
            this.AUR_Duration.Size = new System.Drawing.Size(120, 20);
            this.AUR_Duration.TabIndex = 9;
            // 
            // AUR_Desc
            // 
            this.AUR_Desc.Location = new System.Drawing.Point(110, 98);
            this.AUR_Desc.Multiline = true;
            this.AUR_Desc.Name = "AUR_Desc";
            this.AUR_Desc.Size = new System.Drawing.Size(533, 54);
            this.AUR_Desc.TabIndex = 8;
            // 
            // AUR_Name
            // 
            this.AUR_Name.Location = new System.Drawing.Point(110, 57);
            this.AUR_Name.Name = "AUR_Name";
            this.AUR_Name.Size = new System.Drawing.Size(533, 20);
            this.AUR_Name.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(60, 283);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Texture";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(54, 321);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Modifiers";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Is Debuff";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Consumed On Use";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Duration";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(69, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name";
            // 
            // lst_Auras
            // 
            this.lst_Auras.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_Auras.FormattingEnabled = true;
            this.lst_Auras.Location = new System.Drawing.Point(3, 3);
            this.lst_Auras.Name = "lst_Auras";
            this.lst_Auras.Size = new System.Drawing.Size(200, 470);
            this.lst_Auras.TabIndex = 0;
            this.lst_Auras.SelectedIndexChanged += new System.EventHandler(this.lst_Auras_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.lst_Textures);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(886, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Textures";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lst_Textures
            // 
            this.lst_Textures.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_Textures.FormattingEnabled = true;
            this.lst_Textures.Location = new System.Drawing.Point(3, 3);
            this.lst_Textures.Name = "lst_Textures";
            this.lst_Textures.Size = new System.Drawing.Size(200, 470);
            this.lst_Textures.TabIndex = 0;
            // 
            // txt_ProjectLoc
            // 
            this.txt_ProjectLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProjectLoc.Location = new System.Drawing.Point(104, 3);
            this.txt_ProjectLoc.Name = "txt_ProjectLoc";
            this.txt_ProjectLoc.Size = new System.Drawing.Size(736, 20);
            this.txt_ProjectLoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project location:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "aRPG Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pan_Spells.ResumeLayout(false);
            this.pan_Spells.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_ticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_duration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_cooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Potency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Cost)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUR_Duration)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProjectLoc;
        private System.Windows.Forms.Button btn_ProjLoc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pan_Spells;
        private System.Windows.Forms.ComboBox SPL_School;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox SPL_Gameobj;
        private System.Windows.Forms.ComboBox SPL_noGCD;
        private System.Windows.Forms.NumericUpDown SPL_cooldown;
        private System.Windows.Forms.ComboBox SPL_Texture;
        private System.Windows.Forms.NumericUpDown SPL_Range;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown SPL_Potency;
        private System.Windows.Forms.NumericUpDown SPL_Cost;
        private System.Windows.Forms.TextBox SPL_Desc;
        private System.Windows.Forms.TextBox SPL_Name;
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
        private System.Windows.Forms.ListBox lst_Spells;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lst_Auras;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lst_Textures;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AUR_Desc;
        private System.Windows.Forms.TextBox AUR_Name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox AUR_Mods;
        private System.Windows.Forms.ComboBox AUR_isDebuff;
        private System.Windows.Forms.ComboBox AUR_oneUse;
        private System.Windows.Forms.NumericUpDown AUR_Duration;
        private System.Windows.Forms.ComboBox AUR_texture;
        private System.Windows.Forms.Button btn_LOC_enUS;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SPL_rad_Instant;
        private System.Windows.Forms.RadioButton SPL_rad_AoEDoT;
        private System.Windows.Forms.RadioButton SPL_rad_AoE;
        private System.Windows.Forms.RadioButton SPL_rad_DoT;
        private System.Windows.Forms.NumericUpDown SPL_radius;
        private System.Windows.Forms.NumericUpDown SPL_ticks;
        private System.Windows.Forms.NumericUpDown SPL_duration;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button SPL_btn_Create;
        private System.Windows.Forms.Button SPL_btn_Reset;
        private System.Windows.Forms.Button SPL_btn_Apply;
    }
}

