using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegionLauncher
{
    /// <summary>
    /// Used to deserialize the Addons.json
    /// </summary>
    public class Addons
    {
        public String version;
        public List<Addon> addons;
    }
}
