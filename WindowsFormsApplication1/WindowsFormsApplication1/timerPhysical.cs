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
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class timerPhysical : Form
    {
        public timerPhysical()
        {
            InitializeComponent();

        }
        private Stopwatch s = new Stopwatch();

        string sPath = @"C:\DataFiles\laptimes.txt";
        int lapCount = 0;
        TimeSpan LastBreakTime;

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
            secText.Text = i.ToString("00");
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
            minText.Text = j.ToString("00");
        }

        private void hrTimer_Tick(object sender, EventArgs e)
        {
            k++;
            hrText.Text = k.ToString("00");
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

        private void hrText_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timerPhysical_Load(object sender, EventArgs e)
        {
            secTimer.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lapButton_Click(object sender, EventArgs e)
        {
            
            TimeSpan ts = s.Elapsed;
            TimeSpan LapTime = ts - LastBreakTime;
            LastBreakTime = ts;

            ++lapCount;
            lapList.Items.Add(LapTime.ToString());
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            s.Start();
            secTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            secTimer.Stop();
            System.IO.StreamWriter lapTimes = new System.IO.StreamWriter(sPath);
            foreach (var item in lapList.Items)
            {
                lapTimes.WriteLine(item);
            }
            lapTimes.Close();
        }
    }
}
