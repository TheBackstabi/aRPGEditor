using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace aRPGEditor
{
    public partial class Form1 : Form
    {
        Dictionary<int, Spell> spells;
        Dictionary<int, Aura> auras;
        string projLoc = "";

        public Form1()
        {
            InitializeComponent();
            spells = new Dictionary<int, Spell>();
            auras = new Dictionary<int, Aura>();

            if (File.Exists(Application.StartupPath + "/ProjectLoc.txt"))
            {
                projLoc = txt_ProjectLoc.Text = File.ReadAllText(Application.StartupPath + "/ProjectLoc.txt");
                ReloadAllFiles();
            }
        }

        private void ReloadSpells()
        {
            string filePath = projLoc + "/Assets/Data/Spells.dat";
            if (File.Exists(filePath))
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream load = File.Open(filePath, FileMode.Open);
                spells = (Dictionary<int, Spell>)format.Deserialize(load);
                load.Close();

                lst_Spells.BeginUpdate();
                foreach(Spell spell in spells.Values)
                {
                    lst_Spells.Items.Add(spell.name);
                }
                lst_Spells.EndUpdate();
            }
            else
            {
                MessageBox.Show("Cannot find spell directory.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadAuras()
        {
            string filePath = projLoc + "/Assets/Data/Auras.dat";
            if (File.Exists(filePath))
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream load = File.Open(filePath, FileMode.Open);
                auras = (Dictionary<int, Aura>)format.Deserialize(load);
                load.Close();

                lst_Auras.BeginUpdate();
                foreach(Aura aura in auras.Values)
                {
                    lst_Auras.Items.Add(aura.auraName);
                }
                lst_Auras.EndUpdate();
            }
            else
            {
                MessageBox.Show("Cannot find aura directory.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadAllFiles()
        {
            if (Directory.Exists(projLoc + "/Assets/Data"))
            {
                ReloadSpells();
                ReloadAuras();
            }
            else
            {
                if (MessageBox.Show("Cannot find data folder. Please ensure the root folder of the project is valid.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                projLoc = txt_ProjectLoc.Text = folderBrowserDialog1.SelectedPath;
                ReloadAllFiles();
                File.WriteAllText(Application.StartupPath + "/ProjectLoc.txt", folderBrowserDialog1.SelectedPath);
            }
        }

        private void lst_Spells_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spell selectedSpell = spells[lst_Spells.SelectedIndex];
            SPL_Name.Text = selectedSpell.name;
            SPL_Desc.Text = selectedSpell.desc;
            SPL_Cost.Value = selectedSpell.manaCost;
            SPL_Potency.Value = selectedSpell.damageValue;
            SPL_Range.Value = selectedSpell.range;
            SPL_Texture.Text = selectedSpell.texture;
            SPL_noGCD.Text = selectedSpell.ignoreGCD.ToString();
            SPL_School.Text = selectedSpell.school.ToString();
            SPL_Gameobj.Text = selectedSpell.objectPath;
        }
    }
}
