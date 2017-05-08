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
            this.btn_ProjLoc = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pan_Spells = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.btn_ProjLoc);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.txt_ProjectLoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 552);
            this.panel1.TabIndex = 0;
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
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 523);
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
            this.tabPage1.Size = new System.Drawing.Size(886, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spells";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pan_Spells
            // 
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
            this.pan_Spells.Size = new System.Drawing.Size(676, 484);
            this.pan_Spells.TabIndex = 0;
            // 
            // SPL_School
            // 
            this.SPL_School.FormattingEnabled = true;
            this.SPL_School.Items.AddRange(new object[] {
            "0",
            "1"});
            this.SPL_School.Location = new System.Drawing.Point(117, 389);
            this.SPL_School.Name = "SPL_School";
            this.SPL_School.Size = new System.Drawing.Size(121, 21);
            this.SPL_School.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Seconds";
            // 
            // SPL_Gameobj
            // 
            this.SPL_Gameobj.FormattingEnabled = true;
            this.SPL_Gameobj.Location = new System.Drawing.Point(117, 429);
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
            this.SPL_noGCD.Location = new System.Drawing.Point(117, 349);
            this.SPL_noGCD.Name = "SPL_noGCD";
            this.SPL_noGCD.Size = new System.Drawing.Size(120, 21);
            this.SPL_noGCD.TabIndex = 41;
            // 
            // SPL_cooldown
            // 
            this.SPL_cooldown.Location = new System.Drawing.Point(117, 309);
            this.SPL_cooldown.Name = "SPL_cooldown";
            this.SPL_cooldown.Size = new System.Drawing.Size(105, 20);
            this.SPL_cooldown.TabIndex = 40;
            // 
            // SPL_Texture
            // 
            this.SPL_Texture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SPL_Texture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SPL_Texture.FormattingEnabled = true;
            this.SPL_Texture.Location = new System.Drawing.Point(117, 269);
            this.SPL_Texture.Name = "SPL_Texture";
            this.SPL_Texture.Size = new System.Drawing.Size(533, 21);
            this.SPL_Texture.TabIndex = 39;
            // 
            // SPL_Range
            // 
            this.SPL_Range.Location = new System.Drawing.Point(117, 229);
            this.SPL_Range.Name = "SPL_Range";
            this.SPL_Range.Size = new System.Drawing.Size(105, 20);
            this.SPL_Range.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 191);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "00";
            // 
            // SPL_Potency
            // 
            this.SPL_Potency.Location = new System.Drawing.Point(117, 189);
            this.SPL_Potency.Name = "SPL_Potency";
            this.SPL_Potency.Size = new System.Drawing.Size(105, 20);
            this.SPL_Potency.TabIndex = 36;
            // 
            // SPL_Cost
            // 
            this.SPL_Cost.Location = new System.Drawing.Point(117, 149);
            this.SPL_Cost.Name = "SPL_Cost";
            this.SPL_Cost.Size = new System.Drawing.Size(105, 20);
            this.SPL_Cost.TabIndex = 35;
            // 
            // SPL_Desc
            // 
            this.SPL_Desc.Location = new System.Drawing.Point(117, 79);
            this.SPL_Desc.Multiline = true;
            this.SPL_Desc.Name = "SPL_Desc";
            this.SPL_Desc.Size = new System.Drawing.Size(533, 54);
            this.SPL_Desc.TabIndex = 34;
            // 
            // SPL_Name
            // 
            this.SPL_Name.Location = new System.Drawing.Point(117, 39);
            this.SPL_Name.Name = "SPL_Name";
            this.SPL_Name.Size = new System.Drawing.Size(533, 20);
            this.SPL_Name.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Game Object";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Spell School";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ignores GCD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cooldown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Texture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Potency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mana Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 39);
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
            this.lst_Spells.Size = new System.Drawing.Size(200, 484);
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
            this.tabPage2.Size = new System.Drawing.Size(886, 494);
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
            this.panel2.Size = new System.Drawing.Size(676, 484);
            this.panel2.TabIndex = 1;
            // 
            // AUR_texture
            // 
            this.AUR_texture.FormattingEnabled = true;
            this.AUR_texture.Location = new System.Drawing.Point(116, 265);
            this.AUR_texture.Name = "AUR_texture";
            this.AUR_texture.Size = new System.Drawing.Size(532, 21);
            this.AUR_texture.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Seconds";
            // 
            // AUR_Mods
            // 
            this.AUR_Mods.FormattingEnabled = true;
            this.AUR_Mods.Location = new System.Drawing.Point(116, 303);
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
            this.AUR_isDebuff.Location = new System.Drawing.Point(116, 227);
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
            this.AUR_oneUse.Location = new System.Drawing.Point(116, 189);
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
            this.AUR_Duration.Location = new System.Drawing.Point(116, 151);
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
            this.AUR_Desc.Location = new System.Drawing.Point(116, 80);
            this.AUR_Desc.Multiline = true;
            this.AUR_Desc.Name = "AUR_Desc";
            this.AUR_Desc.Size = new System.Drawing.Size(533, 54);
            this.AUR_Desc.TabIndex = 8;
            // 
            // AUR_Name
            // 
            this.AUR_Name.Location = new System.Drawing.Point(116, 39);
            this.AUR_Name.Name = "AUR_Name";
            this.AUR_Name.Size = new System.Drawing.Size(533, 20);
            this.AUR_Name.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(66, 265);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Texture";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(60, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Modifiers";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Is Debuff";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Consumed On Use";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Duration";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 39);
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
            this.lst_Auras.Size = new System.Drawing.Size(200, 484);
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
            this.tabPage3.Size = new System.Drawing.Size(886, 494);
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
            this.lst_Textures.Size = new System.Drawing.Size(200, 484);
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
            this.ClientSize = new System.Drawing.Size(894, 552);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "aRPG Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pan_Spells.ResumeLayout(false);
            this.pan_Spells.PerformLayout();
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
    }
}

