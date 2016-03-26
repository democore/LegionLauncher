using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LegionLauncher
{
    /// <summary>
    /// Used to start the game with parameters
    /// </summary>
    public class GameStarter
    {
        public static void doStart(Settings settings, List<InstalledAddon> addons, Server server)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = settings.pathToArma + "\\arma3.exe";
            String arguments = "";


            if (settings.additionalStartParameters != "")
            {
                arguments = settings.additionalStartParameters;
            }

            if (settings.loadEmptyWorld)
            {
                arguments += " -world=empty -skipIntro";
            }

            if (settings.showScriptErrors)
            {
                arguments += " -showScriptErrors";
            }

            if (settings.skipIntro)
            {
                arguments += " -nosplash";
            }

            if (!settings.pauseOnDesktop)
            {
                arguments += " -noPause ";
            }

            if (addons.Count > 0)
            {
                arguments += " \"-mod=";
                foreach (InstalledAddon addon in addons)
                {
                    arguments += addon.pathAndName + ";";
                }
                arguments += "\"";
            }

            if (server != null)
            {
                arguments += " -connect=" + server.ip;
                arguments += " -port=" + server.port;
                arguments += " -password=" + server.password;
            }

            startInfo.Arguments = arguments;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    //exeProcess.WaitForExit();
                }
            }
            catch(Exception e)
            {
                // Log error.
            }
        }
    }
}
