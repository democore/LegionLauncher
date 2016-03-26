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
    public partial class Form1 : Form
    {

        ServerCommunication serverCommunication;
        Settings settings;
        List<KeyValuePair<Addon, int>> progressPerAddon = new List<KeyValuePair<Addon, int>>();
        int currentDownloads = 0;

        public Form1()
        {
            InitializeComponent();

            settings = new Settings();

            serverCommunication = new ServerCommunication();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            settings.getSettings();
            setLoadedSettings();
            serverCommunication.getDownloadableAddons(setDownloadableAddons);
            serverCommunication.getModsets(modsetsLoaded);
            
            comboBoxSelectModset.SelectedIndex = 0;
            comboBoxSelectServer.SelectedIndex = 0;
        }

        private void setLoadedSettings()
        {
            textBoxPathToArma.Text = settings.pathToArma;
            checkBoxSettingsStartWithEmptyWorld.Checked = settings.loadEmptyWorld;
            checkBoxSettingsShowBohemiaIntro.Checked = settings.skipIntro;
            checkBoxSettingsShowErrors.Checked = settings.showScriptErrors;
            textBoxSettingsAdditionalParameters.Text = settings.additionalStartParameters;
            textBoxSettingsAddonsPath.Text = settings.addonsPath;
            labelLastDownload.Text = "Letzter Download: " + settings.lastDownload;

            foreach (String s in settings.activeAddons)
            {
                for(int i = 0; i < checkedListBoxAddons.Items.Count; i++)
                {
                    InstalledAddon ia = checkedListBoxAddons.Items[i] as InstalledAddon;
                    if (ia.name == s)
                    {
                        checkedListBoxAddons.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            foreach (Profile profil in settings.profiles)
            {
                listBoxProfiles.Items.Add(profil);
            }
        }

        /// <summary>
        /// Called on TextChange. Looks up if the path to arma is right and sets the image accordingly.
        /// </summary>
        private void textBoxPathToArma_TextChanged(object sender, EventArgs e)
        {
            if (Helper.isArmaDirectory(textBoxPathToArma.Text))
            {
                pictureBoxFoundArma.BackgroundImage = Properties.Resources.icon_found;
                settings.pathToArma = textBoxPathToArma.Text;
                settings.forceSave();
            }
            else
                pictureBoxFoundArma.BackgroundImage = Properties.Resources.icon_delete;
        }

        public void setDownloadableAddons(List<Addon> addons)
        {
            checkedListBoxAddonsForDownload.Items.AddRange(addons.ToArray());
        }

        private void textBoxSettingsAddonsPath_TextChanged(object sender, EventArgs e)
        {
            checkedListBoxAddons.Items.Clear();
            checkedListBoxAddons.Items.AddRange(Helper.getInstalledAddonsFromPath(textBoxSettingsAddonsPath.Text).ToArray());
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxAddons.Items.Count; i++)
            {
                checkedListBoxAddons.SetItemChecked(i, checkBoxSelectAll.Checked);
            }
        }

        private void buttonSettingsAccept_Click(object sender, EventArgs e)
        {
            settings.saveSettings(checkBoxSettingsStartWithEmptyWorld.Checked,  checkBoxSettingsShowBohemiaIntro.Checked, checkBoxSettingsPauseOnDesktop.Checked, 
                checkBoxSettingsShowErrors.Checked, textBoxSettingsAdditionalParameters.Text, textBoxSettingsAddonsPath.Text);
        }

        private List<Addon> getSelectedDownloadAddons()
        {
            List<Addon> addons = new List<Addon>();
            for (int i = 0; i < checkedListBoxAddonsForDownload.Items.Count; i++)
            {
                if (checkedListBoxAddonsForDownload.GetItemChecked(i))
                {
                    addons.Add(checkedListBoxAddonsForDownload.Items[i] as Addon);
                    checkedListBoxAddonsForDownload.SetItemCheckState(i, CheckState.Indeterminate);
                }
            }
            return addons;
        }

        private List<InstalledAddon> getSelectedInstalledAddons()
        {
            List<InstalledAddon> addons = new List<InstalledAddon>();
            for (int i = 0; i < checkedListBoxAddons.Items.Count; i++)
            {
                if (checkedListBoxAddons.GetItemChecked(i))
                {
                    addons.Add(checkedListBoxAddons.Items[i] as InstalledAddon);
                }
            }
            return addons;
        }

        private void UpdateToString(CheckedListBox listBox, Addon addon)
        {
            int count = listBox.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (listBox.Items[i] == addon)
                {
                    //listBox.Items[i] = listBox.Items[i];
                    listBox.Invalidate(listBox.GetItemRectangle(i), false);
                    break;
                }
            }
        }

        private void buttonDownloadNow_Click(object sender, EventArgs e)
        {
            String newDate = DateTime.Now.ToShortDateString();
            settings.setLastDownload(newDate);
            labelLastDownload.Text = "Letzter Download: " + settings.lastDownload;
            List<Addon> selectedAddons = getSelectedDownloadAddons();
            serverCommunication.download(selectedAddons, downloadAdvanced, downloadFinished, settings.addonsPath);
            
            buttonDownloadNow.Enabled = false;
            checkedListBoxAddonsForDownload.SelectionMode = SelectionMode.None;

            currentDownloads += selectedAddons.Count;
        }

        public void downloadAdvanced(Addon addon, int progress, long totalBytes, long currentBytes)
        {
            int cur = (int)(((float)currentBytes / 1000) / 1000);

            if (currentBytes != -1)
            {
                addon.name = addon.originalName + " - " + progress + "%" + " (" + cur + "MB von " + (int)(((float)totalBytes / 1000) / 1000) + "MB)";
            }
            else
            {
                addon.name = addon.originalName + " - Entpacken: " + progress + "%";
            }
            UpdateToString(checkedListBoxAddonsForDownload, addon);
        }

        public void downloadFinished(Addon addon)
        {
            addon.name = addon.originalName + " - Fertig";
            UpdateToString(checkedListBoxAddonsForDownload, addon);

            checkedListBoxAddons.Items.Clear();
            checkedListBoxAddons.Items.AddRange(Helper.getInstalledAddonsFromPath(textBoxSettingsAddonsPath.Text).ToArray());

            currentDownloads--;

            if (currentDownloads == 0)
            {
                buttonDownloadNow.Enabled = true;
                checkedListBoxAddonsForDownload.SelectionMode = SelectionMode.One;
            }
        }

        public void modsetsLoaded(List<Server> servers)
        {
            comboBoxSelectServer.Items.AddRange(servers.ToArray());
            comboBoxSelectModset.Items.AddRange(servers.ToArray());
        }

        public void activateMods(List<String> names)
        {
            List<String> notFound = new List<string>();
            notFound.AddRange(names.ToArray());
            for (int i = 0; i < checkedListBoxAddons.Items.Count; i++)
            {
                checkedListBoxAddons.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListBoxAddons.Items.Count; i++)
            {
                InstalledAddon addon = checkedListBoxAddons.Items[i] as InstalledAddon;
                bool found = false;
                foreach (String s in names)
                {
                    if (addon.name == s)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    checkedListBoxAddons.SetItemChecked(i, true);
                    notFound.Remove(addon.name);
                }
            }

            if (notFound.Count > 0)
            {
                String fehlermeldung = "Folgende Mods wurden nicht gefunden:\r\n";
                foreach (String s in notFound)
                {
                    fehlermeldung += s + "\r\n";
                }
                MessageBox.Show(fehlermeldung);
            }
        }

        private void comboBoxSelectModset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectModset.SelectedIndex > 0)
            {
                Server server = comboBoxSelectModset.SelectedItem as Server;
                activateMods(server.mods);
            }
        }

        private void buttonSearchForArma_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = settings.pathToArma;
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPathToArma.Text = fbd.SelectedPath;
            }
        }

        private void buttonSettingsSetAddonsPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = textBoxSettingsAddonsPath.Text;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSettingsAddonsPath.Text = fbd.SelectedPath;
            }
        }

        private void buttonStartArma_Click(object sender, EventArgs e)
        {
            Server server = null;
            if (comboBoxSelectServer.SelectedIndex > 0)
            {
                server = comboBoxSelectServer.SelectedItem as Server;
                String password = settings.getPasswordForServer(server);
                if (password != "")
                {
                    server.password = password;
                }
                else
                {
                    AskForPassword askForPassword = new AskForPassword(server);
                    askForPassword.ShowDialog();
                    if (askForPassword.dialogResult == AskForPassword.PasswordDialogResult.Abort)
                    {
                        return;
                    }
                    else if (askForPassword.dialogResult == AskForPassword.PasswordDialogResult.Connect)
                    {
                        server.password = askForPassword.password;
                    }
                    else if (askForPassword.dialogResult == AskForPassword.PasswordDialogResult.SaveAndConnect)
                    {
                        server.password = askForPassword.password;
                        settings.saveServerPassword(server, askForPassword.password);
                    }
                    
                }
            }
            GameStarter.doStart(settings, getSelectedInstalledAddons(), server);
        }

        private void checkedListBoxAddons_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> addons = new List<string>();
            foreach(InstalledAddon ia in getSelectedInstalledAddons())
            {
                addons.Add(ia.name);
            }
            settings.setActiveAddons(addons);
        }

        private void buttonSettingsEditPasswords_Click(object sender, EventArgs e)
        {
            EditPasswords editPasswords = new EditPasswords(settings);
            editPasswords.ShowDialog();
        }

        private void buttonSettingsReloadAddons_Click(object sender, EventArgs e)
        {
            checkedListBoxAddons.Items.Clear();
            checkedListBoxAddons.Items.AddRange(Helper.getInstalledAddonsFromPath(textBoxSettingsAddonsPath.Text).ToArray());
        }

        private void buttonSettingsShowModstring_Click(object sender, EventArgs e)
        {
            ViewModstring viewModstring = new ViewModstring(getSelectedInstalledAddons());
            if (viewModstring.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                activateMods(viewModstring.chosenAddons);
            }
        }

        public List<String> getAllInstalledAddonsAsString()
        {
            List<String> allAddons = new List<string>();
            foreach (InstalledAddon installedAddon in checkedListBoxAddons.Items)
            {
                allAddons.Add(installedAddon.name);
            }
            return allAddons;
        }

        public List<String> getSelectedInstalledAddonsAsString()
        {
            List<String> allAddons = new List<string>();
            int i = 0;
            foreach (InstalledAddon installedAddon in checkedListBoxAddons.Items)
            {
                if (checkedListBoxAddons.GetItemChecked(i))
                {
                    allAddons.Add(installedAddon.name);
                }
                i++;
            }
            return allAddons;
        }

        private void buttonProfileAdd_Click(object sender, EventArgs e)
        {
            ProfileEditor editor = new ProfileEditor(null, getAllInstalledAddonsAsString());
            if (editor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.saveProfile(editor.profile);
                listBoxProfiles.Items.Add(editor.profile);
            }
        }

        private void buttonProfilesAddCurrentSelection_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.addons = new List<string>();
            profile.addons.AddRange(getSelectedInstalledAddonsAsString().ToArray());
            ProfileEditor editor = new ProfileEditor(profile, getAllInstalledAddonsAsString());
            if (editor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.saveProfile(editor.profile);
                listBoxProfiles.Items.Add(editor.profile);
            }
        }

        private void buttonProfileEdit_Click(object sender, EventArgs e)
        {
            if (listBoxProfiles.SelectedIndex != -1)
            {
                ProfileEditor editor = new ProfileEditor(listBoxProfiles.SelectedItem as Profile, getAllInstalledAddonsAsString());
                if (editor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    settings.editProfile(editor.profile);
                    listBoxProfiles.Items[listBoxProfiles.SelectedIndex] = editor.profile;
                }
            }
        }

        private void buttonProfileDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProfiles.SelectedIndex != -1)
            {
                listBoxProfiles.Items.Remove(listBoxProfiles.SelectedItem);
            }
        }

        private void buttonProfilesActivate_Click(object sender, EventArgs e)
        {
            if (listBoxProfiles.SelectedIndex != -1)
            {
                activateMods((listBoxProfiles.SelectedItem as Profile).addons);
            }
        }
    }
}
