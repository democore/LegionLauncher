using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegionLauncher
{
    /// <summary>
    /// to load and save Settings
    /// </summary>
    public class Settings
    {
        public String pathToArma;
        public bool loadEmptyWorld;
        public bool skipIntro;
        public bool showScriptErrors;
        public bool pauseOnDesktop;
        public String additionalStartParameters;
        public String addonsPath;
        public String lastDownload;
        public List<String> activeAddons = new List<string>();
        public List<SavedServerPassword> savedServerPasswords = new List<SavedServerPassword>();
        public List<Profile> profiles = new List<Profile>();

        public void getSettings()
        {
            pathToArma = Properties.Settings.Default.PathToArma;
            loadEmptyWorld = Properties.Settings.Default.LoadEmptyWorld;
            skipIntro = Properties.Settings.Default.SkipIntro;
            showScriptErrors = Properties.Settings.Default.ShowScriptErrors;
            pauseOnDesktop = Properties.Settings.Default.pauseOnDesktop;
            additionalStartParameters = Properties.Settings.Default.AdditionalStartParameters;
            addonsPath = Properties.Settings.Default.AddonsPath;
            lastDownload = Properties.Settings.Default.LastDownload;

            if (Properties.Settings.Default.activeAddons != null)
            {
                activeAddons = new List<string>();
                foreach (String s in Properties.Settings.Default.activeAddons)
                {
                    activeAddons.Add(s);
                }
            }

            if (Properties.Settings.Default.ServerPasswords != null)
            {
                foreach (String s in Properties.Settings.Default.ServerPasswords)
                {
                    savedServerPasswords.Add(new SavedServerPassword(s));
                }
            }

            if (Properties.Settings.Default.Profiles != null)
            {
                foreach (String s in Properties.Settings.Default.Profiles)
                {
                    profiles.Add(new Profile(s));
                }
            }
        }

        public void saveProfile(Profile profile)
        {
            if (Properties.Settings.Default.Profiles == null)
            {
                Properties.Settings.Default.Profiles = new System.Collections.Specialized.StringCollection();
            }
            Properties.Settings.Default.Profiles.Add(profile.serialize());
            Properties.Settings.Default.Save();
        }

        public void editProfile(Profile profile)
        {
            int index = -1;
            for (int i = 0; i < profiles.Count; i++)
            {
                if (profiles[i].name == profile.name)
                {
                    Properties.Settings.Default.Profiles[i] = profile.serialize();
                    Properties.Settings.Default.Save();
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                profiles[index] = profile;
            }
        }

        public void setLastDownload(String lastDownload)
        {
            this.lastDownload = lastDownload;
            Properties.Settings.Default.LastDownload = this.lastDownload;
            Properties.Settings.Default.Save();
        }

        public void saveServerPassword(Server server, String password)
        {
            int index = 0;
            bool found = false;
            foreach (SavedServerPassword save in savedServerPasswords)
            {
                if (save.serverIpAndPort.Equals(server.ip + ":" + server.port))
                {
                    found = true;
                    break;
                }
                index++;
            }

            if (found)
            {
                savedServerPasswords[index].password = password;
                Properties.Settings.Default.ServerPasswords[index] = server.getCredentials();
                Properties.Settings.Default.Save();
            }
            else
            {
                String newOne = server.getCredentials();
                if (savedServerPasswords == null)
                {
                    savedServerPasswords = new List<SavedServerPassword>();
                }
                savedServerPasswords.Add(new SavedServerPassword(newOne));
                if (Properties.Settings.Default.ServerPasswords == null)
                {
                    Properties.Settings.Default.ServerPasswords = new System.Collections.Specialized.StringCollection();
                }
                Properties.Settings.Default.ServerPasswords.Add(newOne);
                Properties.Settings.Default.Save();
            }
        }

        public void setNewPassword(SavedServerPassword saved)
        {
            int index = 0;
            bool found = false;
            foreach (SavedServerPassword save in savedServerPasswords)
            {
                if (save.serverIpAndPort.Equals(saved.serverIpAndPort))
                {
                    found = true;
                    break;
                }
                index++;
            }

            savedServerPasswords[index].password = saved.password;
            Properties.Settings.Default.ServerPasswords[index] = saved.credentials;
            Properties.Settings.Default.Save();
        }

        public String getPasswordForServer(Server server)
        {
            foreach (SavedServerPassword save in savedServerPasswords)
            {
                if (save.serverIpAndPort.Equals(server.ip + ":" + server.port))
                {
                    return save.password;
                }
            }
            return "";
        }

        public void setActiveAddons(List<String> activeAddons)
        {
            this.activeAddons = activeAddons;
            Properties.Settings.Default.activeAddons = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.activeAddons.AddRange(activeAddons.ToArray());
            Properties.Settings.Default.Save();
        }



        public void saveSettings(bool loadEmptyWorld, bool skipIntro, bool showScriptErrors, bool pauseOnDesktop, String additionalStartParameters, String addonsPath)
        {
            Properties.Settings.Default.LoadEmptyWorld = loadEmptyWorld;
            Properties.Settings.Default.SkipIntro = skipIntro;
            Properties.Settings.Default.ShowScriptErrors = showScriptErrors;
            Properties.Settings.Default.AdditionalStartParameters = additionalStartParameters;
            Properties.Settings.Default.AddonsPath = addonsPath;
            Properties.Settings.Default.pauseOnDesktop = pauseOnDesktop;
            Properties.Settings.Default.Save();
            getSettings();
        }

        public void forceSave()
        {
            Properties.Settings.Default.Save();
        }
    }
}
