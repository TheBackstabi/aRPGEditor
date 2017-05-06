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
            this.button1 = new System.Windows.Forms.Button();
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
            this.txt_ProjectLoc = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lst_Spells = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lst_Auras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.pan_Spells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_cooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Potency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Cost)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pan_Spells);
            this.panel1.Controls.Add(this.txt_ProjectLoc);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 549);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(871, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pan_Spells
            // 
            this.pan_Spells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Spells.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.pan_Spells.Location = new System.Drawing.Point(215, 29);
            this.pan_Spells.Name = "pan_Spells";
            this.pan_Spells.Size = new System.Drawing.Size(695, 520);
            this.pan_Spells.TabIndex = 1;
            // 
            // SPL_School
            // 
            this.SPL_School.FormattingEnabled = true;
            this.SPL_School.Location = new System.Drawing.Point(120, 381);
            this.SPL_School.Name = "SPL_School";
            this.SPL_School.Size = new System.Drawing.Size(121, 21);
            this.SPL_School.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Seconds";
            // 
            // SPL_Gameobj
            // 
            this.SPL_Gameobj.FormattingEnabled = true;
            this.SPL_Gameobj.Location = new System.Drawing.Point(120, 421);
            this.SPL_Gameobj.Name = "SPL_Gameobj";
            this.SPL_Gameobj.Size = new System.Drawing.Size(533, 21);
            this.SPL_Gameobj.TabIndex = 20;
            // 
            // SPL_noGCD
            // 
            this.SPL_noGCD.FormattingEnabled = true;
            this.SPL_noGCD.Location = new System.Drawing.Point(120, 341);
            this.SPL_noGCD.Name = "SPL_noGCD";
            this.SPL_noGCD.Size = new System.Drawing.Size(120, 21);
            this.SPL_noGCD.TabIndex = 18;
            // 
            // SPL_cooldown
            // 
            this.SPL_cooldown.Location = new System.Drawing.Point(120, 301);
            this.SPL_cooldown.Name = "SPL_cooldown";
            this.SPL_cooldown.Size = new System.Drawing.Size(105, 20);
            this.SPL_cooldown.TabIndex = 17;
            this.SPL_cooldown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SPL_Texture
            // 
            this.SPL_Texture.FormattingEnabled = true;
            this.SPL_Texture.Location = new System.Drawing.Point(120, 261);
            this.SPL_Texture.Name = "SPL_Texture";
            this.SPL_Texture.Size = new System.Drawing.Size(533, 21);
            this.SPL_Texture.TabIndex = 16;
            // 
            // SPL_Range
            // 
            this.SPL_Range.Location = new System.Drawing.Point(120, 221);
            this.SPL_Range.Name = "SPL_Range";
            this.SPL_Range.Size = new System.Drawing.Size(105, 20);
            this.SPL_Range.TabIndex = 15;
            this.SPL_Range.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 183);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "00";
            // 
            // SPL_Potency
            // 
            this.SPL_Potency.Location = new System.Drawing.Point(120, 181);
            this.SPL_Potency.Name = "SPL_Potency";
            this.SPL_Potency.Size = new System.Drawing.Size(105, 20);
            this.SPL_Potency.TabIndex = 13;
            this.SPL_Potency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SPL_Cost
            // 
            this.SPL_Cost.Location = new System.Drawing.Point(120, 141);
            this.SPL_Cost.Name = "SPL_Cost";
            this.SPL_Cost.Size = new System.Drawing.Size(105, 20);
            this.SPL_Cost.TabIndex = 12;
            this.SPL_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SPL_Desc
            // 
            this.SPL_Desc.Location = new System.Drawing.Point(120, 71);
            this.SPL_Desc.Multiline = true;
            this.SPL_Desc.Name = "SPL_Desc";
            this.SPL_Desc.Size = new System.Drawing.Size(533, 54);
            this.SPL_Desc.TabIndex = 11;
            // 
            // SPL_Name
            // 
            this.SPL_Name.Location = new System.Drawing.Point(120, 31);
            this.SPL_Name.Name = "SPL_Name";
            this.SPL_Name.Size = new System.Drawing.Size(533, 20);
            this.SPL_Name.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Game Object";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Spell School";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ignores GCD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cooldown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Texture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Potency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mana Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txt_ProjectLoc
            // 
            this.txt_ProjectLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProjectLoc.Location = new System.Drawing.Point(317, 3);
            this.txt_ProjectLoc.Name = "txt_ProjectLoc";
            this.txt_ProjectLoc.Size = new System.Drawing.Size(551, 20);
            this.txt_ProjectLoc.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(214, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lst_Spells);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(206, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spells";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lst_Spells
            // 
            this.lst_Spells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Spells.FormattingEnabled = true;
            this.lst_Spells.Location = new System.Drawing.Point(3, 3);
            this.lst_Spells.Name = "lst_Spells";
            this.lst_Spells.Size = new System.Drawing.Size(200, 517);
            this.lst_Spells.TabIndex = 0;
            this.lst_Spells.SelectedIndexChanged += new System.EventHandler(this.lst_Spells_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lst_Auras);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(206, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lst_Auras
            // 
            this.lst_Auras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Auras.FormattingEnabled = true;
            this.lst_Auras.Location = new System.Drawing.Point(3, 3);
            this.lst_Auras.Name = "lst_Auras";
            this.lst_Auras.Size = new System.Drawing.Size(200, 517);
            this.lst_Auras.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(220, 6);
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
            this.ClientSize = new System.Drawing.Size(910, 549);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "aRPG Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan_Spells.ResumeLayout(false);
            this.pan_Spells.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_cooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Potency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPL_Cost)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lst_Spells;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lst_Auras;
        private System.Windows.Forms.Panel pan_Spells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProjectLoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.ComboBox SPL_School;
    }
}

