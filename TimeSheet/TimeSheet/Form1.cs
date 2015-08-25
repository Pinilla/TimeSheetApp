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

        int timeLeft = 900;
       

        public TimeSheetHelper()
        {

            InitializeComponent();
            //timer.Interval = 900000;
            timer.Interval = 2000;
            timer.Tick += new EventHandler(TimerEventProcessor);
            displayTimer.Tick += new EventHandler(displayTimer_Tick);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            displayTimer.Start();
            btnStart.Enabled = false;
        }

        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            Application.Run(new Text_Pop_Up());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 3600000;
            timer.Stop();
            timer.Start();
            MessageBox.Show(timer.ToString());
            
        }

        private void btnLunchIn_Click(object sender, EventArgs e)
        {
            timer.Interval = 900000;
            timer.Stop();
            timer.Start();
            MessageBox.Show("Welcome Back, you took a " + timer.ToString() + "long lunch.");
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTimer.Text = (timeLeft / 60).ToString() + ":" + (timeLeft % 60).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
