using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LegionLauncher
{
    public static class Helper
    {
        public static bool isArmaDirectory(String path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                bool found = false;
                foreach (var file in di.GetFiles("*.exe"))
                {
                    if (file.Name == "arma3.exe")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static List<Addon> createListFromJSON(String json)
        {
            Addons addons = JsonConvert.DeserializeObject<Addons>(json);
            return addons.addons;
        }

        public static List<InstalledAddon> getInstalledAddonsFromPath(String path)
        {
            List<InstalledAddon> returner = new List<InstalledAddon>();

            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                foreach (DirectoryInfo directory in di.GetDirectories("@*"))
                {
                    InstalledAddon addon = new InstalledAddon(directory);

                    returner.Add(addon);
                }
            }

            return returner;
        }

        public static List<Server> createserversFromModsetsJSON(String json)
        {
            Servers servers = JsonConvert.DeserializeObject<Servers>(json);
            return servers.servers;
        }
    }
}
