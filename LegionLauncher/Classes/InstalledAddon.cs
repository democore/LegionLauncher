using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LegionLauncher
{
    /// <summary>
    /// Used to describe an installed addon
    /// </summary>
    public class InstalledAddon
    {
        public String name = "";
        public String pathAndName = "";
        public DirectoryInfo directoryInfo;

        public InstalledAddon(DirectoryInfo directory)
        {
            directoryInfo = directory;
            name = directory.Name;
            pathAndName = directory.FullName;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
