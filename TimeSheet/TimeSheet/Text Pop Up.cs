using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace TimeSheet
{
    public partial class Text_Pop_Up : Form
    {
        public Text_Pop_Up()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("C:\\TimeSheets\\Timesheet - " + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + ".txt");
            outputFile.WriteLine(DateTime.Now.ToString("g",
                  DateTimeFormatInfo.InvariantInfo) + " - " + txtStatus.Text + "\n");
            outputFile.Close();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
