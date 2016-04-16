using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPlayHelper.src.windows;
using SKYPE4COMLib;
using System.IO;

namespace LetsPlayHelper.src.managers
{
    class DataManager
    {
		//Saves the main version of LPH
        private String _VERSION = "Alpha v0.0.1";

		//Temporary storage of the recPath Properity.
        private String folder = Properties.Settings.Default.recPath.ToString();

        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

		//Basic constructor 
        public DataManager()
        {
            
        }
	
		//Returns the version to the other classes
        public String getVersion()
        {
            return _VERSION;
        }

		///<summary>
		///Converting and shorting the variables
		///</summary>
        static double ConvertBytesToMegabytes(double bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        static double ConvertMegabytesToGigabytes(double megabytes) // SMALLER
        {
            // 1024 megabyte in a gigabyte
            return megabytes / 1024.0;
        }

        public String getFreeDiskSpace(String folder)
        {
            System.IO.DriveInfo drive = new System.IO.DriveInfo(folder);
            System.IO.DriveInfo a = new System.IO.DriveInfo(drive.Name);

            double HDPercentageUsed = a.TotalSize - a.AvailableFreeSpace ;
            HDPercentageUsed = ConvertBytesToMegabytes(HDPercentageUsed);
            HDPercentageUsed = ConvertMegabytesToGigabytes(HDPercentageUsed);
            HDPercentageUsed = Math.Round(HDPercentageUsed, 2);
            return HDPercentageUsed.ToString();
        }

        public String getMaxDiskSpace(String folder)
        {
            System.IO.DriveInfo drive = new System.IO.DriveInfo(folder);
            System.IO.DriveInfo a = new System.IO.DriveInfo(drive.Name);

            double space = a.TotalSize;
            space = ConvertBytesToMegabytes(space);
            space = ConvertMegabytesToGigabytes(space);
            space = Math.Round(space, 2);

            return space.ToString();
        }

        public int getPercentage()
        {
            System.IO.DriveInfo drive = new System.IO.DriveInfo(folder);
            System.IO.DriveInfo a = new System.IO.DriveInfo(drive.Name);

            long HDPercentageUsed = 100 - (100 * a.AvailableFreeSpace / a.TotalSize);
            return Convert.ToInt32(HDPercentageUsed);
        }

        public bool startPathExists()
        {
            if (File.Exists(folder))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                
    }
}
