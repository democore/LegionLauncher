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
    public partial class AskForPassword : Form
    {
        public String password;
        public Server server;
        public enum PasswordDialogResult { Abort, Connect, SaveAndConnect };
        public PasswordDialogResult dialogResult = PasswordDialogResult.Abort; 

        public AskForPassword(Server server)
        {
            InitializeComponent();
            this.server = server;
            if (server != null)
            {
                labelServername.Text = server.name;
                labelServerIpAndPort.Text = server.ip + ":" + server.port;
            }
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveAndConnect_Click(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
            dialogResult = PasswordDialogResult.SaveAndConnect;
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
            dialogResult = PasswordDialogResult.Connect;
            this.Close();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConnect_Click(null, null);
            }
        }

        private void AskForPassword_Load(object sender, EventArgs e)
        {
            textBoxPassword.Select();
        }
    }
}
