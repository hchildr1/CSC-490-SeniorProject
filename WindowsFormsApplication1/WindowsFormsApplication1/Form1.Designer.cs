namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.hrColon = new System.Windows.Forms.Label();
            this.minColon = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // secTimer
            // 
            this.secTimer.Enabled = true;
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // secText
            // 
            this.secText.AutoSize = true;
            this.secText.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.secText.Location = new System.Drawing.Point(244, 18);
            this.secText.Name = "secText";
            this.secText.Size = new System.Drawing.Size(84, 93);
            this.secText.TabIndex = 1;
            this.secText.Text = "0";
            // 
            // minTimer
            // 
            this.minTimer.Enabled = true;
            this.minTimer.Interval = 60000;
            this.minTimer.Tick += new System.EventHandler(this.minTimer_Tick);
            // 
            // minText
            // 
            this.minText.AutoSize = true;
            this.minText.BackColor = System.Drawing.Color.Transparent;
            this.minText.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.minText.Location = new System.Drawing.Point(122, 18);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(84, 93);
            this.minText.TabIndex = 2;
            this.minText.Text = "0";
            // 
            // hrTimer
            // 
            this.hrTimer.Enabled = true;
            this.hrTimer.Interval = 3600000;
            this.hrTimer.Tick += new System.EventHandler(this.hrTimer_Tick);
            // 
            // hrText
            // 
            this.hrText.AutoSize = true;
            this.hrText.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.hrText.Location = new System.Drawing.Point(2, 18);
            this.hrText.Name = "hrText";
            this.hrText.Size = new System.Drawing.Size(84, 93);
            this.hrText.TabIndex = 3;
            this.hrText.Text = "0";
            // 
            // hrColon
            // 
            this.hrColon.AutoSize = true;
            this.hrColon.BackColor = System.Drawing.Color.Transparent;
            this.hrColon.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.hrColon.Location = new System.Drawing.Point(66, 18);
            this.hrColon.Name = "hrColon";
            this.hrColon.Size = new System.Drawing.Size(67, 93);
            this.hrColon.TabIndex = 4;
            this.hrColon.Text = ":";
            // 
            // minColon
            // 
            this.minColon.AutoSize = true;
            this.minColon.BackColor = System.Drawing.Color.Transparent;
            this.minColon.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.minColon.Location = new System.Drawing.Point(187, 18);
            this.minColon.Name = "minColon";
            this.minColon.Size = new System.Drawing.Size(67, 93);
            this.minColon.TabIndex = 5;
            this.minColon.Text = ":";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 122);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(353, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(339, 16);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 144);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.secText);
            this.Controls.Add(this.hrText);
            this.Controls.Add(this.hrColon);
            this.Controls.Add(this.minColon);
            this.Controls.Add(this.minText);
            this.Name = "Form1";
            this.Text = "TestTimer";
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
        private System.Windows.Forms.Label hrColon;
        private System.Windows.Forms.Label minColon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

