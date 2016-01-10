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
        TimeSpan tsCounter;

        public LunchPopUp()
        { 
            
            InitializeComponent();

            tsCounter = TimeSpan.FromHours(1);
            timer1.Interval = 1000;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tsCounter.TotalSeconds > 0)
            {
                tsCounter = tsCounter.Subtract(TimeSpan.FromSeconds(1));
                txtLunchTimer.Text = tsCounter.ToString(@"mm\:ss");
            }
        }
    }
}

