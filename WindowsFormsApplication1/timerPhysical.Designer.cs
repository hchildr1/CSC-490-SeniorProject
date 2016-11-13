namespace WindowsFormsApplication1
{
    partial class timerPhysical
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

        #region Windows Form Designer code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.secText = new System.Windows.Forms.Label();
            this.minTimer = new System.Windows.Forms.Timer(this.components);
            this.minText = new System.Windows.Forms.Label();
            this.hrTimer = new System.Windows.Forms.Timer(this.components);
            this.hrText = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hrminColon = new System.Windows.Forms.Label();
            this.minsecColon = new System.Windows.Forms.Label();
            this.lapButton = new System.Windows.Forms.Button();
            this.lapList = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.ovrTimeText = new System.Windows.Forms.Label();
            this.ovrPresTime = new System.Windows.Forms.Label();
            this.ovrallTime = new System.Windows.Forms.MaskedTextBox();
            this.numSlidesLabel = new System.Windows.Forms.Label();
            this.numSlidesBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // secTimer
            // 
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // secText
            // 
            this.secText.AutoSize = true;
            this.secText.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.secText.Location = new System.Drawing.Point(244, 18);
            this.secText.Name = "secText";
            this.secText.Size = new System.Drawing.Size(128, 93);
            this.secText.TabIndex = 1;
            this.secText.Text = "00";
            // 
            // minTimer
            // 
            this.minTimer.Interval = 60000;
            this.minTimer.Tick += new System.EventHandler(this.minTimer_Tick);
            // 
            // minText
            // 
            this.minText.AutoSize = true;
            this.minText.BackColor = System.Drawing.Color.Transparent;
            this.minText.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.minText.Location = new System.Drawing.Point(116, 18);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(128, 93);
            this.minText.TabIndex = 2;
            this.minText.Text = "00";
            // 
            // hrTimer
            // 
            this.hrTimer.Interval = 3600000;
            this.hrTimer.Tick += new System.EventHandler(this.hrTimer_Tick);
            // 
            // hrText
            // 
            this.hrText.AutoSize = true;
            this.hrText.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.hrText.Location = new System.Drawing.Point(-3, 18);
            this.hrText.Name = "hrText";
            this.hrText.Size = new System.Drawing.Size(128, 93);
            this.hrText.TabIndex = 3;
            this.hrText.Text = "00";

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 232);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";


            // 
            // hrminColon
            // 
            this.hrminColon.AutoSize = true;
            this.hrminColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.hrminColon.Location = new System.Drawing.Point(98, 36);
            this.hrminColon.Name = "hrminColon";
            this.hrminColon.Size = new System.Drawing.Size(37, 55);
            this.hrminColon.TabIndex = 8;
            this.hrminColon.Text = ":";
            // 
            // minsecColon
            // 
            this.minsecColon.AutoSize = true;
            this.minsecColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.minsecColon.Location = new System.Drawing.Point(225, 36);
            this.minsecColon.Name = "minsecColon";
            this.minsecColon.Size = new System.Drawing.Size(37, 55);
            this.minsecColon.TabIndex = 9;
            this.minsecColon.Text = ":";

            // 
            // lapButton
            // 
            this.lapButton.Location = new System.Drawing.Point(147, 122);
            this.lapButton.Name = "lapButton";
            this.lapButton.Size = new System.Drawing.Size(115, 48);
            this.lapButton.TabIndex = 10;
            this.lapButton.Text = "LAP";
            this.lapButton.UseVisualStyleBackColor = true;
            this.lapButton.Click += new System.EventHandler(this.lapButton_Click);
            // 
            // lapList
            // 
            this.lapList.FormattingEnabled = true;
            this.lapList.Location = new System.Drawing.Point(410, 36);
            this.lapList.Name = "lapList";
            this.lapList.Size = new System.Drawing.Size(220, 134);
            this.lapList.TabIndex = 11;

            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 122);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(122, 48);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(269, 122);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 48);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(588, 180);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(42, 23);
            this.timeButton.TabIndex = 14;
            this.timeButton.Text = "Set";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // ovrTimeText
            // 
            this.ovrTimeText.AutoSize = true;
            this.ovrTimeText.Location = new System.Drawing.Point(539, 185);
            this.ovrTimeText.Name = "ovrTimeText";
            this.ovrTimeText.Size = new System.Drawing.Size(43, 13);
            this.ovrTimeText.TabIndex = 16;
            this.ovrTimeText.Text = "minutes";
            // 
            // ovrPresTime
            // 
            this.ovrPresTime.AutoSize = true;
            this.ovrPresTime.Location = new System.Drawing.Point(369, 185);
            this.ovrPresTime.Name = "ovrPresTime";
            this.ovrPresTime.Size = new System.Drawing.Size(128, 13);
            this.ovrPresTime.TabIndex = 17;
            this.ovrPresTime.Text = "Alotted Presentation Time";
            // 
            // ovrallTime
            // 
            this.ovrallTime.Location = new System.Drawing.Point(503, 180);
            this.ovrallTime.Name = "ovrallTime";
            this.ovrallTime.Size = new System.Drawing.Size(29, 20);
            this.ovrallTime.TabIndex = 18;
            // 
            // numSlidesLabel
            // 
            this.numSlidesLabel.AutoSize = true;
            this.numSlidesLabel.Location = new System.Drawing.Point(407, 207);
            this.numSlidesLabel.Name = "numSlidesLabel";
            this.numSlidesLabel.Size = new System.Drawing.Size(87, 13);
            this.numSlidesLabel.TabIndex = 19;
            this.numSlidesLabel.Text = "Number of Slides";

            // 
            // numSlidesBox
            // 
            this.numSlidesBox.Location = new System.Drawing.Point(503, 207);
            this.numSlidesBox.Name = "numSlidesBox";
            this.numSlidesBox.Size = new System.Drawing.Size(29, 20);
            this.numSlidesBox.TabIndex = 20;
            // 
            // timerPhysical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 254);
            this.Controls.Add(this.numSlidesBox);
            this.Controls.Add(this.numSlidesLabel);
            this.Controls.Add(this.ovrallTime);
            this.Controls.Add(this.ovrPresTime);
            this.Controls.Add(this.ovrTimeText);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lapList);
            this.Controls.Add(this.lapButton);
            this.Controls.Add(this.minsecColon);
            this.Controls.Add(this.hrminColon);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hrText);
            this.Controls.Add(this.secText);
            this.Controls.Add(this.minText);
            this.Name = "timerPhysical";
            this.Text = "TestTimer";
            this.Load += new System.EventHandler(this.timerPhysical_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer secTimer;
        private System.Windows.Forms.Label secText;
        private System.Windows.Forms.Timer minTimer;
        private System.Windows.Forms.Label minText;
        private System.Windows.Forms.Timer hrTimer;
        private System.Windows.Forms.Label hrText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label hrminColon;
        private System.Windows.Forms.Label minsecColon;
        private System.Windows.Forms.Button lapButton;
        private System.Windows.Forms.ListBox lapList;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Label ovrTimeText;
        private System.Windows.Forms.Label ovrPresTime;
        private System.Windows.Forms.MaskedTextBox ovrallTime;
        private System.Windows.Forms.Label numSlidesLabel;
        private System.Windows.Forms.TextBox numSlidesBox;
    }
}

