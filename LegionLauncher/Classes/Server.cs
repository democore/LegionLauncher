using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegionLauncher
{
    public class Server
    {
        public String ip = "";
        public String password = "";
        public String port;
        public String name;
        public List<String> mods;

        public override string ToString()
        {
            return name;
        }

        public String getCredentials()
        {
            return ip + ":" + port + ";" + password + ";" + name;
        }
    }
}
