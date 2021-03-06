﻿using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LetsPlayHelper.src.managers
{ 
    /// <summary>
    /// SatusManager class is the most important class. It checks the recording status and starts the 
    /// timer in the main class.
    /// </summary>

    class StatusManager
    {
        private bool recording = false;
        private DateTime recordTime;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;
        private Form1 mainWindow;
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private Skype skype;

        private bool hasPlayed = false;

        public StatusManager()
        {
            recordTime = new DateTime();
            mainWindow = new Form1();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);

            skype = new Skype();
        }

        /// <summary>
        /// Returns the rec status.
        /// </summary>
        public bool getRecStatus()
        {
            return recording;
        }

        /// <summary>
        /// Starts the recording and sets the global variable.
        /// </summary>
        public void startRec()
        {
            recording = true;


            recordTime = DateTime.Now;

            // Store the total elapsed time so far
            _totalElapsedTime = _currentElapsedTime;

            _timer.Start();
            
            if(Properties.Settings.Default.skypeAutoAFK == true)
            {
                if (skype.Client.IsRunning)
                {
                    skype.ChangeUserStatus(TUserStatus.cusDoNotDisturb);
                }
                else
                {
                    
                }
            }
          
        }
        
        /// <summary>
        /// Stops the recording and sets the global variable.
        /// </summary>
        public void stopRec()
        {
            recording = false;
            _timer.Stop();

            if (Properties.Settings.Default.skypeAutoAFK == true)
            {
                if (skype.Client.IsRunning)
                {
                    skype.ChangeUserStatus(TUserStatus.cusOnline);
                }
                else
                {
                    
                }
            }
        }

        /// <summary>
        /// Returns the current recording time.
        /// </summary>
        /// <returns></returns>
        public TimeSpan getRecTime()
        {
            return _currentElapsedTime;
        }

        /// <summary>
        /// This does the actual counting.
        /// </summary>
        void _timer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - recordTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;
            playOnSelectedTime(Properties.Settings.Default.playOnTime);
         }

        /// <summary>
        /// Resets the recording time.
        /// </summary>
        public void resetRecTime()
        {
            _timer.Stop();
            hasPlayed = false;
            _totalElapsedTime = TimeSpan.Zero;
            _currentElapsedTime = TimeSpan.Zero;
        }

        public void playOnSelectedTime(int minutes)
        {
            

            if(_currentElapsedTime.TotalMinutes > minutes)
            {
                if(hasPlayed == false)
                {
                    try
                    {
                        SoundPlayer sndPlayer = new SoundPlayer(LetsPlayHelper.Properties.Resources.timerend);
                        sndPlayer.Play();
                        hasPlayed = true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error - " + e.Message);
                    }
                }else
                {
                    return;
                }
            }
        }
    }
}
