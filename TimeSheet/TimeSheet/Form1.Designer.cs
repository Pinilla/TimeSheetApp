namespace TimeSheet
{
    partial class TimeSheetHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLunchOut = new System.Windows.Forms.Button();
            this.btnLunchIn = new System.Windows.Forms.Button();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLunchOut
            // 
            this.btnLunchOut.Location = new System.Drawing.Point(29, 198);
            this.btnLunchOut.Name = "btnLunchOut";
            this.btnLunchOut.Size = new System.Drawing.Size(75, 23);
            this.btnLunchOut.TabIndex = 1;
            this.btnLunchOut.Text = "Lunch Out";
            this.btnLunchOut.UseVisualStyleBackColor = true;
            this.btnLunchOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLunchIn
            // 
            this.btnLunchIn.Location = new System.Drawing.Point(172, 198);
            this.btnLunchIn.Name = "btnLunchIn";
            this.btnLunchIn.Size = new System.Drawing.Size(75, 23);
            this.btnLunchIn.TabIndex = 2;
            this.btnLunchIn.Text = "Lunch In";
            this.btnLunchIn.UseVisualStyleBackColor = true;
            this.btnLunchIn.Click += new System.EventHandler(this.btnLunchIn_Click);
            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 1000;
            // 
            // timer
            // 
            this.timer.Interval = 90000;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(84, 94);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(107, 39);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeSheetHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnLunchIn);
            this.Controls.Add(this.btnLunchOut);
            this.Controls.Add(this.btnStart);
            this.Name = "TimeSheetHelper";
            this.Text = "Time Sheet Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLunchOut;
        private System.Windows.Forms.Button btnLunchIn;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

