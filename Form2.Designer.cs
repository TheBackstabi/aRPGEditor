namespace aRPGEditor
{
    partial class DLG_AuraModifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_SpellID = new System.Windows.Forms.ComboBox();
            this.cmb_Mod = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.num_Value = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spell ID Affected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modifier Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // cmb_SpellID
            // 
            this.cmb_SpellID.FormattingEnabled = true;
            this.cmb_SpellID.Location = new System.Drawing.Point(120, 32);
            this.cmb_SpellID.Name = "cmb_SpellID";
            this.cmb_SpellID.Size = new System.Drawing.Size(259, 21);
            this.cmb_SpellID.TabIndex = 3;
            // 
            // cmb_Mod
            // 
            this.cmb_Mod.FormattingEnabled = true;
            this.cmb_Mod.Items.AddRange(new object[] {
            "Damage",
            "Cost",
            "Cooldown",
            "Proc"});
            this.cmb_Mod.Location = new System.Drawing.Point(120, 85);
            this.cmb_Mod.Name = "cmb_Mod";
            this.cmb_Mod.Size = new System.Drawing.Size(259, 21);
            this.cmb_Mod.TabIndex = 4;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(371, 203);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(290, 203);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // num_Value
            // 
            this.num_Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_Value.Location = new System.Drawing.Point(121, 139);
            this.num_Value.Maximum = new decimal(new int[] {
            214000000,
            0,
            0,
            0});
            this.num_Value.Minimum = new decimal(new int[] {
            214000000,
            0,
            0,
            -2147483648});
            this.num_Value.Name = "num_Value";
            this.num_Value.Size = new System.Drawing.Size(258, 20);
            this.num_Value.TabIndex = 8;
            // 
            // DLG_AuraModifier
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(458, 236);
            this.Controls.Add(this.num_Value);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cmb_Mod);
            this.Controls.Add(this.cmb_SpellID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DLG_AuraModifier";
            this.Text = "Edit Modfier";
            ((System.ComponentModel.ISupportInitialize)(this.num_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_SpellID;
        private System.Windows.Forms.ComboBox cmb_Mod;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown num_Value;
    }
}