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
    public partial class EditPasswords : Form
    {
        Settings settings;
        public EditPasswords(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();

            listBoxSavedPasswords.Items.AddRange(settings.savedServerPasswords.ToArray());
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxSavedPasswords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxSavedPasswords.SelectedIndex != -1)
            {
                EditPassword editPassword = new EditPassword(listBoxSavedPasswords.SelectedItem as SavedServerPassword, settings);
                editPassword.ShowDialog();
            }
        }
    }
}
