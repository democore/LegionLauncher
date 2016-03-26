using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegionLauncher
{
    public class SavedServerPassword
    {
        public String password;
        public String serverIpAndPort;
        public String name;
        public String credentials;

        public SavedServerPassword(String credentials)
        {
            List<String> credentialsList = new List<string>();
            credentialsList.AddRange(credentials.Split(new char[] { ';' }));
            serverIpAndPort = credentialsList[0];
            password = credentialsList[1];
            if(credentialsList.Count > 2)
                name = credentialsList[2];

            this.credentials = credentials;
        }

        public override string ToString()
        {
            return name + " - " + serverIpAndPort;
        }

        public String refreshCredentials()
        {
            return credentials = serverIpAndPort + ";" + password + ";" + name;
        }
    }
}
