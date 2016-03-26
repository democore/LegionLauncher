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
    public partial class EditPassword : Form
    {
        SavedServerPassword savedServerPassword;
        Settings settings;

        public EditPassword(SavedServerPassword savedServerPassword, Settings settings)
        {
            InitializeComponent();

            this.savedServerPassword = savedServerPassword;
            this.settings = settings;

            labelServername.Text = savedServerPassword.name;
            labelIpAndPort.Text = savedServerPassword.serverIpAndPort;
            textBoxPassword.Text = savedServerPassword.password;
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            savedServerPassword.password = textBoxPassword.Text;
            savedServerPassword.refreshCredentials();
            settings.setNewPassword(savedServerPassword);
            this.Close();
        }
    }
}
