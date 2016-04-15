using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LetsPlayHelper.src.managers;
using LetsPlayHelper.src.windows;
using System.Runtime.InteropServices;

namespace LetsPlayHelper
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The main class, which handles all the input.
        /// </summary>
        
        private StatusManager sm;
        private DataManager dm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dm = new DataManager();
            sm = new StatusManager();
            timer1.Start();

            
        }

        //Timer only for realtime events
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.recDisk.ToString();
            progressBar1.Value = dm.getPercentage();
            freeSpaceLabel.Text = dm.getFreeDiskSpace() + " / " + dm.getMaxDiskSpace();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if(sm.getRecStatus() == true)
                {
                    sm.stopRec();
                    recStatus.ForeColor = Color.Black;
                    recStatus.Text = "Stopped";
                    sm.resetRecTime();
                }
                else
                {
                    sm.startRec();
                    recStatus.ForeColor = Color.Red;
                    recStatus.Text = "Recording";
                    recTimer.Start();
                }
            }
           }

        public Timer getTimer()
        {
            return recTimer;
        }

        private void recTimer_Tick(object sender, EventArgs e)
        {
            recTime.Text = sm.getRecTime().ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            sw.Show();
        }

   }
}
