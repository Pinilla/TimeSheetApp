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
    public partial class LunchPopUp : Form
    {
        int timeLeft;

        public LunchPopUp()
        {
            
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timeLeft = 3600;
            timer1.Interval = 1000;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                txtLunchTimer.Text = (timeLeft / 60).ToString() + ":" + (timeLeft % 60).ToString();
               
            }
        }
    }
}

