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
        double allotedSlideTime;
        double currentSlideTime;
        double prevAllotedTime;
        double nextAllotedTime;


        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        
        private void secTimer_Tick(object sender, EventArgs e)
        {
            i++;
            secText.Text = i.ToString("00");
            if (i == 59)
            {
                i = -1;
            }

        
        }

        private void minTimer_Tick(object sender, EventArgs e)
        {
            j++;
            minText.Text = j.ToString("00");
            if (j == 59)
            {
                j = -1;
            }
        }

        private void hrTimer_Tick(object sender, EventArgs e)
        {
            k++;
            hrText.Text = k.ToString("00");
            if (k == 24)
            {
                k = -1;
            }
        }



        private void timerPhysical_Load(object sender, EventArgs e)
        {
            secTimer.Stop();
        }



        private void lapButton_Click(object sender, EventArgs e)
        {
            
            TimeSpan ts = s.Elapsed;
            TimeSpan LapTime = ts - LastBreakTime;
            LastBreakTime = ts;

            currentSlideTime = LapTime.Milliseconds;

            ++lapCount;
            lapList.Items.Add(LapTime.ToString());
            nextAllotedTime = 0;
            if(currentSlideTime < allotedSlideTime)
            {
                nextAllotedTime = (allotedSlideTime + (allotedSlideTime - currentSlideTime));

            }

            string nextSlideTimeStr = nextAllotedTime.ToString(); //DEBUG CODE
            MessageBox.Show(nextSlideTimeStr);
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            s.Start();
            secTimer.Start();
            minTimer.Start();
            hrTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            secTimer.Stop();
            minTimer.Stop();
            hrTimer.Stop();

            System.IO.StreamWriter lapTimes = new System.IO.StreamWriter(sPath);
            foreach (var item in lapList.Items)
            {
                lapTimes.WriteLine(item);
            }
            lapTimes.Close();
        }

        public void timeButton_Click(object sender, EventArgs e)
        {
            double ovrPresTime;
            double numSlides;
            ovrPresTime = Convert.ToInt32(ovrallTime.Text);
            ovrPresTime = int.Parse(ovrallTime.Text);
            numSlides = Convert.ToInt32(numSlidesBox.Text);
            numSlides = int.Parse(numSlidesBox.Text);

            
            allotedSlideTime = (ovrPresTime / numSlides);
            allotedSlideTime = (allotedSlideTime * 60000);

            string allotedSlideTimeStr = allotedSlideTime.ToString(); //DEBUG CODE
            MessageBox.Show(allotedSlideTimeStr);




        }

    }
}
