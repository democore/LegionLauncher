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
    public partial class ViewModstring : Form
    {
        public List<InstalledAddon> addons;
        public List<String> chosenAddons;

        public ViewModstring(List<InstalledAddon> addons)
        {
            InitializeComponent();
            this.addons = addons;

            String addonsString = "";
            foreach (InstalledAddon addon in addons)
            {
                addonsString += addon.name + ";";
            }
            textBoxModstring.Text = addonsString;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            String active = textBoxModstring.Text;
            chosenAddons = new List<string>();
            chosenAddons.AddRange(active.Split(new char[] { ';' }));

            chosenAddons.RemoveAt(chosenAddons.Count - 1);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }
    }
}
