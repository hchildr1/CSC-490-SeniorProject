using System;

namespace finalTimer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hrText = new System.Windows.Forms.Label();
            this.minText = new System.Windows.Forms.Label();
            this.secText = new System.Windows.Forms.Label();
            this.hrTimer1 = new System.Windows.Forms.Timer(this.components);
            this.minTimer = new System.Windows.Forms.Timer(this.components);
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hrText
            // 
            this.hrText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.hrText.Location = new System.Drawing.Point(13, 9);
            this.hrText.Name = "hrText";
            this.hrText.Size = new System.Drawing.Size(77, 49);
            this.hrText.TabIndex = 0;
            this.hrText.Text = "00";
            // 
            // minText
            // 
            this.minText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.minText.Location = new System.Drawing.Point(65, 9);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(64, 47);
            this.minText.TabIndex = 1;
            this.minText.Text = "00";
            this.minText.Click += new System.EventHandler(this.minText_Click);
            // 
            // secText
            // 
            this.secText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.secText.Location = new System.Drawing.Point(116, 9);
            this.secText.Name = "secText";
            this.secText.Size = new System.Drawing.Size(69, 37);
            this.secText.TabIndex = 2;
            this.secText.Text = "00";
            // 
            // hrTimer1
            // 
            this.hrTimer1.Interval = 3600000;
            this.hrTimer1.Tick += new System.EventHandler(this.hrTimer1_Tick);
            // 
            // minTimer
            // 
            this.minTimer.Interval = 60000;
            this.minTimer.Tick += new System.EventHandler(this.minTimer_Tick);
            // 
            // secTimer
            // 
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 74);
            this.Controls.Add(this.secText);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.hrText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void minText_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label hrText;
        private System.Windows.Forms.Label minText;
        private System.Windows.Forms.Label secText;
        private System.Windows.Forms.Timer hrTimer1;
        private System.Windows.Forms.Timer minTimer;
        private System.Windows.Forms.Timer secTimer;
    }
}