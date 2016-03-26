using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LegionLauncher
{
    /// <summary>
    ///  Used to describe an Addon from the server
    /// </summary>
    public class Addon
    {
        public String originalName = "";
        private String Name;
        public String name
        {
            get { return Name; }
            set { Name = value; if (originalName == "") { originalName = value; } }
        }
        public String realFileName = "";
        public String link = "";
        public System.String Link
        {
            get { return link; }
            set { link = value; if (value != "") { realFileName = value.Split(new char[] { '/' }).Last(); } }
        }
        public String downloadedPath = "";

        public override String ToString()
        {
            return name;
        }
    }
}
