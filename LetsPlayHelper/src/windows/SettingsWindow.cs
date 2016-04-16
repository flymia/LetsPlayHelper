using LetsPlayHelper.src.managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayHelper.src.windows
{
    public partial class SettingsWindow : Form
    {
        /// <summary>
        /// This class is for the settings. It saves the settings in a specific XML file.
        /// </summary>
        private DataManager dm;
        private UpdateManager um;


        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            //Gets the current version to show it on the label.
            dm = new DataManager();
            currentVersionLabel.Text = dm.getVersion();

            um = new UpdateManager();

            
            pathTextBox.Text = Properties.Settings.Default.recPath.ToString();
            playTimeBox.Value = Properties.Settings.Default.playOnTime;

            if(Properties.Settings.Default.skypeAutoAFK == true)
            {
                skypeCheckBox.Checked = true;
            }
            else
            {
                skypeCheckBox.Checked = false;
            }

            if(Properties.Settings.Default.TSAutoMute == true)
            {
                TScheckBox.Checked = true;
            }
            else
            {
                TScheckBox.Checked = false;
            }
            if(Properties.Settings.Default.playTimerSound == true)
            {
                playSoundcheckBox.Checked = true;
            }else
            {
                playSoundcheckBox.Checked = false;
            }

        }

        /// <summary>
        /// Update check logic
        /// </summary>
        private void checkForButton_Click(object sender, EventArgs e)
        {
            if (um.isVersionOut())
            {
                availVersionLabel.ForeColor = Color.Red;
                availVersionLabel.Text = um.getVersion();
                MessageBox.Show("New version is out! Please download now!", "New version", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                availVersionLabel.ForeColor = Color.Green;
                availVersionLabel.Text = um.getVersion();
            }
        }

        /// <summary>
        /// Save logic. 
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.recPath = pathTextBox.Text;
            Properties.Settings.Default.playOnTime = Convert.ToInt32(playTimeBox.Value);

            if (skypeCheckBox.Checked)
            {
                Properties.Settings.Default.skypeAutoAFK = true;
            }
            else
            {
                Properties.Settings.Default.skypeAutoAFK = false;
            }
            
            if (TScheckBox.Checked)
            {
                Properties.Settings.Default.TSAutoMute = true;
            }
            else
            {
                Properties.Settings.Default.TSAutoMute = false;
            }
            if (playSoundcheckBox.Checked)
            {
                Properties.Settings.Default.playTimerSound = true;
            }else
            {
                Properties.Settings.Default.playTimerSound = false;
            }
            

            Properties.Settings.Default.Save();
            this.Close();    
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            pathTextBox.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
