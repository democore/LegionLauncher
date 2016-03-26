using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LegionLauncher
{
    public partial class ProfileEditor : Form
    {
        public Profile profile;

        public ProfileEditor(Profile profile, List<String> allAddons)
        {
            InitializeComponent();
            this.profile = profile;

            if (profile != null)
            {
                foreach (String s in profile.addons)
                {
                    allAddons.Remove(s);
                }

                listBoxAddons.Items.AddRange(profile.addons.ToArray());

                textBoxName.Text = profile.name;
            }

            comboBoxAddAddon.Items.AddRange(allAddons.ToArray());
            if (comboBoxAddAddon.Items.Count > 0)
            {
                comboBoxAddAddon.SelectedIndex = 0;
            }
        }

        private void buttonDeleteSelection_Click(object sender, EventArgs e)
        {
            if (listBoxAddons.SelectedIndex != -1)
            {
                comboBoxAddAddon.Items.Add(listBoxAddons.SelectedItem);
                listBoxAddons.Items.Remove(listBoxAddons.SelectedItem);
            }
        }

        private void buttonAddAddon_Click(object sender, EventArgs e)
        {
            if (comboBoxAddAddon.SelectedIndex != -1)
            {
                listBoxAddons.Items.Add(comboBoxAddAddon.SelectedItem);
                comboBoxAddAddon.Items.Remove(comboBoxAddAddon.SelectedItem);
                if (comboBoxAddAddon.Items.Count > 0)
                {
                    comboBoxAddAddon.SelectedIndex = comboBoxAddAddon.SelectedIndex + 1;
                }
                else
                {
                    comboBoxAddAddon.Text = "";
                }
            }
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                profile = new Profile();
                profile.name = textBoxName.Text;
                profile.addons = new List<string>();
                foreach (String s in listBoxAddons.Items)
                {
                    profile.addons.Add(s);
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Das Profil hat keinen Namen");
            }
        }
    }
}
