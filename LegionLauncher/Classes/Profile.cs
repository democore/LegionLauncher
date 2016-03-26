using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegionLauncher
{
    public class Profile
    {
        public String name;
        public List<String> addons;

        public Profile(String descriptor)
        {
            List<String> descriptions = new List<string>();
            addons = new List<string>();

            descriptions.AddRange(descriptor.Split(new char[] { ',' }));
            name = descriptions[0];
            for (int i = 1; i < descriptions.Count - 1; i++)
            {
                addons.Add(descriptions[i]);
            }
        }
        public Profile()
        {

        }

        public override string ToString()
        {
            return name;
        }

        public String serialize()
        {
            String addonsString = "";
            foreach (String installedAddon in addons)
            {
                addonsString += installedAddon + ",";
            }
            return name + "," + addonsString;
        }
    }
}
