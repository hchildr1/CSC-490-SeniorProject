using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double i = 0;
        double j = 0;
        double k = 0;


        private void Form1_Load(object sender, System.EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            i++;
            secText.Text = i.ToString();
            if (i == 59)
            {
                i = -1;
            }
            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Step = 1;

        
        }

        private void minTimer_Tick(object sender, EventArgs e)
        {
            j++;
            minText.Text = j.ToString() + " :";
        }

        private void hrTimer_Tick(object sender, EventArgs e)
        {
            k++;
            hrText.Text = k.ToString() + " :";
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i<=100; i++)
            {
                Thread.Sleep(100);

                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChange(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;

            this.Text = e.ProgressPercentage.ToString();
        }
    }
}
