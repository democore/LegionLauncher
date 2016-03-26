using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LegionLauncher
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niky war doof und hat einen Fehler gemacht :3\r\n\r\nAm besten du schickst ihm einen Screenshot hiervon:\r\n\r\n" + ex.Message + ex.StackTrace);
            }
        }
    }
}
