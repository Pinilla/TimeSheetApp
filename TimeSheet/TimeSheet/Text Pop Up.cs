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
            if (!Directory.Exists(Properties.Settings.Default.TimesheetDirectory))
            {
                Directory.CreateDirectory(Properties.Settings.Default.TimesheetDirectory);
            }

            StreamWriter outputFile;
            outputFile = File.AppendText(String.Format("{0}\\Timesheet - {1}-{2}.txt", Properties.Settings.Default.TimesheetDirectory, DateTime.Now.Month, DateTime.Now.Day));
            //outputFile = File.AppendText("C:\\TimeSheets\\Timesheet - " + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + ".txt");
            outputFile.WriteLine(DateTime.Now.ToString("g", DateTimeFormatInfo.InvariantInfo) + " - " + txtStatus.Text + "\n");
            outputFile.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
