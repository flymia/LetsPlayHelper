using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPlayHelper.src.windows;

namespace LetsPlayHelper.src.managers
{
    class DataManager
    {
        private String _VERSION = "Alpha v0.0.1";

        private String folder = Properties.Settings.Default.recPath.ToString();

        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public DataManager()
        {
           
        }

        public String getVersion()
        {
            return _VERSION;
        }

        static double ConvertBytesToMegabytes(double bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        static double ConvertMegabytesToGigabytes(double megabytes) // SMALLER
        {
            // 1024 megabyte in a gigabyte
            return megabytes / 1024.0;
        }

        public String getFreeDiskSpace()
        {
            System.IO.DriveInfo drive = new System.IO.DriveInfo(folder);
            System.IO.DriveInfo a = new System.IO.DriveInfo(drive.Name);

            double HDPercentageUsed = a.TotalSize - a.AvailableFreeSpace ;
            HDPercentageUsed = ConvertBytesToMegabytes(HDPercentageUsed);
            HDPercentageUsed = ConvertMegabytesToGigabytes(HDPercentageUsed);
            HDPercentageUsed = Math.Round(HDPercentageUsed, 2);
            return HDPercentageUsed.ToString();
        }

        public String getMaxDiskSpace()
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
                
    }
}
