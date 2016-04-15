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

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            //Gets the current version to show it on the label.
            dm = new DataManager();
            currentVersionLabel.Text = dm.getVersion();

            comboBox1.Text = Properties.Settings.Default.recDisk.ToString();
            pathTextBox.Text = Properties.Settings.Default.recPath.ToString();
        }


        /// <summary>
        /// Update check logic
        /// </summary>
        private void checkForButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Save logic. 
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.recDisk = comboBox1.Text;
            Properties.Settings.Default.recPath = pathTextBox.Text;

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
