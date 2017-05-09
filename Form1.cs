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
        Dictionary<string, Texture> textures;
        IList<string> gameResources;
        string currentSpellType;

        public Form1()
        {
            InitializeComponent();
            spells = new Dictionary<int, Spell>();
            auras = new Dictionary<int, Aura>();
            textures = new Dictionary<string, Texture>();
            gameResources = new List<string>();
            if (File.Exists(Application.StartupPath + "/ProjectLoc.txt"))
            {
                string projLoc = txt_ProjectLoc.Text = File.ReadAllText(Application.StartupPath + "/ProjectLoc.txt");
                ReloadAllFiles(projLoc);
            }
        }

        private void SaveAllFiles()
        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream save = File.Create(txt_ProjectLoc.Text + "/Assets/Data/Spells.dat");
            format.Serialize(save, spells);
            save.Close();
            save = File.Create(txt_ProjectLoc.Text + "/Assets/Data/Auras.dat");
            format.Serialize(save, auras);
            save.Close();
            save = File.Create(txt_ProjectLoc.Text + "/Assets/Data/Textures.dat");
            format.Serialize(save, textures);
            save.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllFiles();
        }

        private void ReloadSpells(string projLoc)
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
                    lst_Spells.Items.Add("("+spell.id+") "+spell.name);
                }
                lst_Spells.EndUpdate();
            }
            else
            {
                MessageBox.Show("Cannot find spell file.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadAuras(string projLoc)
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
                    lst_Auras.Items.Add("("+aura.id+") "+aura.auraName);
                }
                lst_Auras.EndUpdate();
            }
            else
            {
                MessageBox.Show("Cannot find aura file.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadTextures(string projLoc)
        {
            string filePath = projLoc + "/Assets/Data/Textures.dat";
            if (File.Exists(filePath))
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream load = File.Open(filePath, FileMode.Open);
                textures = (Dictionary<string, Texture>)format.Deserialize(load);
                load.Close();

                lst_Textures.BeginUpdate();
                foreach(Texture texture in textures.Values)
                {
                    lst_Textures.Items.Add(texture.name);
                }
                lst_Textures.EndUpdate();

                SPL_Texture.DataSource = lst_Textures.Items;
                AUR_texture.DataSource = lst_Textures.Items;
            }
            else
            {
                MessageBox.Show("Cannot find texture file.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllGameResources(string projLoc)
        {
            gameResources.Clear();
            string filePath = projLoc + "/Assets/Resources";
            if (Directory.Exists(filePath))
            {
                foreach (string folder in Directory.EnumerateDirectories(filePath))
                {
                    foreach (string file in Directory.EnumerateFiles(folder, "*.prefab"))
                    {
                        string fileName = file.Substring(filePath.Length+1).Split('.')[0];
                        gameResources.Add(fileName);
                    }
                }

                SPL_Gameobj.DataSource = gameResources;
            }
            else
            {
                MessageBox.Show("Game resources directory is missing!", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadAllFiles(string projLoc)
        {
            if (Directory.Exists(projLoc + "/Assets/Data"))
            {
                GetAllGameResources(projLoc);
                ReloadSpells(projLoc);
                ReloadAuras(projLoc);
                ReloadTextures(projLoc);
            }
            else
            {
                if (MessageBox.Show("Cannot find data directory. Please ensure the root folder of the project is valid.", "Invlid Path", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    btn_ProjLoc.PerformClick();
            }
        }

        private void btn_ProjLoc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string projLoc = txt_ProjectLoc.Text = folderBrowserDialog1.SelectedPath;
                ReloadAllFiles(projLoc);
                File.WriteAllText(Application.StartupPath + "/ProjectLoc.txt", folderBrowserDialog1.SelectedPath);
            }
        }

        private void SPL_radioButtonChanged(object sender, EventArgs e)
        {
            RadioButton selected = (RadioButton)sender;
            currentSpellType = selected.Text;
            switch (selected.Text)
            {
                case "DoT":
                    SPL_duration.Enabled = true;
                    SPL_radius.Enabled = false;
                    SPL_ticks.Enabled = true;
                    break;
                case "AoE":
                    SPL_duration.Enabled = false;
                    SPL_radius.Enabled = true;
                    SPL_ticks.Enabled = false;
                    break;
                case "AoEDoT":
                    SPL_duration.Enabled = true;
                    SPL_radius.Enabled = true;
                    SPL_ticks.Enabled = true;
                    break;
                default:
                    SPL_duration.Enabled = false;
                    SPL_radius.Enabled = false;
                    SPL_ticks.Enabled = false;
                    break;
            }
        }

        private void BuildSpellData()
        {
            Spell selectedSpell = spells[lst_Spells.SelectedIndex];
            SPL_Name.Text = selectedSpell.name;
            SPL_Desc.Text = selectedSpell.desc;
            SPL_Cost.Value = selectedSpell.manaCost;
            SPL_Potency.Value = selectedSpell.damageValue;
            SPL_Range.Value = selectedSpell.range;
            SPL_Texture.Text = selectedSpell.texture;
            SPL_cooldown.Value = selectedSpell.cooldown;
            SPL_noGCD.Text = selectedSpell.ignoreGCD.ToString();
            SPL_School.Text = selectedSpell.school.ToString();
            SPL_Gameobj.Text = selectedSpell.objectPath;
            switch (selectedSpell.type)
            {
                case "DoT":
                    SPL_rad_DoT.Checked = true;
                    SPL_duration.Enabled = true;
                    SPL_duration.Value = selectedSpell.duration;
                    SPL_radius.Enabled = false;
                    SPL_radius.Value = 0;
                    SPL_ticks.Enabled = true;
                    SPL_ticks.Value = selectedSpell.ticks;
                    break;
                case "AoE":
                    SPL_rad_AoE.Checked = true;
                    SPL_duration.Enabled = false;
                    SPL_duration.Value = 0;
                    SPL_radius.Enabled = true;
                    SPL_radius.Value = selectedSpell.radius;
                    SPL_ticks.Enabled = false;
                    SPL_ticks.Value = 0;
                    break;
                case "AoEDoT":
                    SPL_rad_AoEDoT.Checked = true;
                    SPL_duration.Enabled = true;
                    SPL_duration.Value = selectedSpell.duration;
                    SPL_radius.Enabled = true;
                    SPL_radius.Value = selectedSpell.radius;
                    SPL_ticks.Enabled = true;
                    SPL_ticks.Value = selectedSpell.ticks;
                    break;
                default:
                    SPL_rad_Instant.Checked = true;
                    SPL_duration.Enabled = false;
                    SPL_duration.Value = 0;
                    SPL_radius.Enabled = false;
                    SPL_radius.Value = 0;
                    SPL_ticks.Enabled = false;
                    SPL_ticks.Value = 0;
                    break;
            }
        }

        private void lst_Spells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Spells.SelectedIndex >= 0)
            {
                BuildSpellData();
            }
        }

        private void SPL_btn_Reset_Click(object sender, EventArgs e)
        {
            if (lst_Spells.SelectedIndex >= 0)
            {
                BuildSpellData();
            }
        }

        private void SPL_btn_Apply_Click(object sender, EventArgs e)
        {
            Spell selectedSpell = spells[lst_Spells.SelectedIndex];
            selectedSpell.name = SPL_Name.Text;
            selectedSpell.desc = SPL_Desc.Text;
            selectedSpell.manaCost = (int)SPL_Cost.Value;
            selectedSpell.damageValue = (int)SPL_Potency.Value;
            selectedSpell.range = (int)SPL_Range.Value;
            selectedSpell.texture = SPL_Texture.Text;
            selectedSpell.cooldown = (int)SPL_cooldown.Value;
            selectedSpell.ignoreGCD = bool.Parse(SPL_noGCD.Text);
            selectedSpell.school = int.Parse(SPL_School.Text);
            selectedSpell.objectPath = SPL_Gameobj.Text;
            selectedSpell.type = currentSpellType;
            switch (selectedSpell.type)
            {
                case "DoT":
                    selectedSpell.duration = (int)SPL_duration.Value;
                    selectedSpell.ticks = (int)SPL_ticks.Value;
                    break;
                case "AoE":
                    selectedSpell.radius = (int)SPL_radius.Value;
                    break;
                case "AoEDoT":
                    selectedSpell.duration = (int)SPL_duration.Value;
                    selectedSpell.radius = (int)SPL_radius.Value;
                    selectedSpell.ticks = (int)SPL_ticks.Value;
                    break;
            }

            lst_Spells.Items[lst_Spells.SelectedIndex] = "(" + selectedSpell.id + ") " + selectedSpell.name;
            spells[lst_Spells.SelectedIndex] = selectedSpell;
            SaveAllFiles();
        }

        private void SPL_btn_Create_Click(object sender, EventArgs e)
        {
            Spell selectedSpell = new Spell();
            selectedSpell.id = spells.Values.Last().id + 1;
            selectedSpell.name = SPL_Name.Text;
            selectedSpell.desc = SPL_Desc.Text;
            selectedSpell.manaCost = (int)SPL_Cost.Value;
            selectedSpell.damageValue = (int)SPL_Potency.Value;
            selectedSpell.range = (int)SPL_Range.Value;
            selectedSpell.texture = SPL_Texture.Text;
            selectedSpell.cooldown = (int)SPL_cooldown.Value;
            selectedSpell.ignoreGCD = bool.Parse(SPL_noGCD.Text);
            selectedSpell.school = int.Parse(SPL_School.Text);
            selectedSpell.objectPath = SPL_Gameobj.Text;
            switch (selectedSpell.type)
            {
                case "DoT":
                    selectedSpell.duration = (int)SPL_duration.Value;
                    selectedSpell.ticks = (int)SPL_ticks.Value;
                    break;
                case "AoE":
                    selectedSpell.radius = (int)SPL_radius.Value;
                    break;
                case "AoEDoT":
                    selectedSpell.duration = (int)SPL_duration.Value;
                    selectedSpell.radius = (int)SPL_radius.Value;
                    selectedSpell.ticks = (int)SPL_ticks.Value;
                    break;
            }

            lst_Spells.Items.Add("(" + selectedSpell.id + ") " + selectedSpell.name);
            spells.Add(selectedSpell.id, selectedSpell);
            SaveAllFiles();
        }

        private void BuildAuraData()
        {
            Aura selectedAura = auras[lst_Auras.SelectedIndex];
            AUR_Name.Text = selectedAura.auraName;
            AUR_Desc.Text = selectedAura.desc;
            AUR_Duration.Value = (Decimal)selectedAura.duration;
            AUR_isDebuff.Text = selectedAura.isDebuff.ToString();
            AUR_oneUse.Text = selectedAura.consumedOnUse.ToString();
            AUR_texture.Text = selectedAura.texture;

            AUR_Mods.Items.Clear();
            AUR_Mods.BeginUpdate();
            foreach (Aura.Modifier mod in selectedAura.mods)
            {
                string auraString = mod.spellID + ":" + mod.mod.ToString() + ":" + mod.value;
                AUR_Mods.Items.Add(auraString);
            }
            AUR_Mods.EndUpdate();
        }

        private void lst_Auras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Auras.SelectedIndex >= 0)
            {
                BuildAuraData();
            }
        }

        private void AUR_Modifiers_DoubleClick(object sender, EventArgs e)
        {
            DLG_AuraModifier dialog = new DLG_AuraModifier(auras[lst_Auras.SelectedIndex].mods[AUR_Mods.SelectedIndex], spells);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AuraMods modifier;
                if (Enum.TryParse(dialog.Modifier, out modifier))
                {
                    Aura.Modifier newMod = auras[lst_Auras.SelectedIndex].mods[AUR_Mods.SelectedIndex];
                    newMod.mod = modifier;
                    newMod.spellID = dialog.SpellID;
                    newMod.value = (float)dialog.Value;
                    auras[lst_Auras.SelectedIndex].mods[AUR_Mods.SelectedIndex] = newMod;
                    AUR_Mods.Items[AUR_Mods.SelectedIndex] = newMod.spellID + ":" + newMod.mod.ToString() + ":" + newMod.value;
                    dialog.Close();
                    AUR_Mods.Update();
                }
                else
                {
                    MessageBox.Show("Invalid modifier type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
