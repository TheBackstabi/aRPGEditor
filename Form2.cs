using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aRPGEditor
{
    public partial class DLG_AuraModifier : Form
    {
        public Decimal Value
        {
            get { return num_Value.Value; }
        }
        public string Modifier
        {
            get { return cmb_Mod.Text; }
        }
        public int SpellID
        {
            get { return int.Parse(cmb_SpellID.Text); }
        }
        public DLG_AuraModifier()
        {
            InitializeComponent();
        }

        public DLG_AuraModifier(Aura.Modifier mod, Dictionary<int,Spell> spells)
        {
            InitializeComponent();
            cmb_SpellID.BeginUpdate();
            cmb_SpellID.Items.Add(-1);
            foreach (Spell spell in spells.Values)
                cmb_SpellID.Items.Add(spell.id);
            cmb_SpellID.EndUpdate();
            cmb_SpellID.Text = mod.spellID.ToString();
            cmb_Mod.Text = mod.mod.ToString();
            num_Value.Value = (Decimal)mod.value;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
