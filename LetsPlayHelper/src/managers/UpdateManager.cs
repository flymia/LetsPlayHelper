using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace LetsPlayHelper.src.managers
{
    class UpdateManager
    {
        private DataManager dm;
        private WebClient updateChecker = new WebClient();
        private String container;

        public UpdateManager()
        {
            dm = new DataManager();
        }

        public bool isVersionOut()
        {
            string versionFile = updateChecker.DownloadString("http://31.214.243.215/LPH/update.txt");
            this.container = versionFile;
            if (versionFile.Contains(dm.getVersion()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getVersion()
        {
            return container;
        }
    }
}
