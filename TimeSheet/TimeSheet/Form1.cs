using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheet
{

    public partial class TimeSheetHelper : Form
    {
        //store a global timespan to reference from the timer
        TimeSpan tsCounter;
        string timeDisplayFormat = @"mm\:ss";
        

        public TimeSheetHelper()
        {

            InitializeComponent();
            btnStop.Enabled = false;

            timer.Interval = 1000;

            //timer.Interval = Properties.Settings.Default.PollInterval * 1000 * 60; //change this to a setting, later we can make it configurable to the user, if we want
            timer.Tick += new EventHandler(TimerEventProcessor);
            //displayTimer.Tick += new EventHandler(displayTimer_Tick);
        }

        #region FormEvents

        private void btnStart_Click(object sender, EventArgs e)
        {
            //displayTimer.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            ResetTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer.Stop();
            displayTimer.Stop();
        }

        private void btnLunchOut_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DateTime clockOut = DateTime.Now;

            LunchPopUp lpu = new LunchPopUp();
            lpu.ShowDialog();

            TimeSpan lunchTime = DateTime.Now - clockOut;

            MessageBox.Show("Welcome Back, you took a " + lunchTime.ToString(timeDisplayFormat) + " long lunch.");

            ResetTimer();
        }

        #endregion

        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {

            //swapped this over to a timespan - gives a little more convenience when working with the time manipulation and formatting
            //if there is time left, then we need to decrement our timespan and then update the display
            if (tsCounter.TotalSeconds > 0)
            {
                tsCounter = tsCounter.Subtract(TimeSpan.FromSeconds(1));
                lblTimer.Text = tsCounter.ToString(timeDisplayFormat);
            } else
            { //if there isn't time left, we need to stop the timer, launch the prompt form, and then reset the timer after it's been updated
                timer.Stop();
                Text_Pop_Up tpu = new Text_Pop_Up();
                tpu.TopMost = true;
                tpu.ShowDialog();
                ResetTimer();
            }
            
        }

        private void ResetTimer()
        {
            tsCounter = TimeSpan.FromMinutes(Properties.Settings.Default.PollInterval);
            timer.Start();
        }

    }
}
