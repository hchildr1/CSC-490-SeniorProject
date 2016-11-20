using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Diagnostics;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;


namespace finalTimer
{
    

    public partial class Ribbon1
    {

        
        
        public Stopwatch s = new Stopwatch();

        string sPath = @"C:\DataFiles\laptimes.csv";
        int lapCount = 0;
        TimeSpan LastBreakTime;

        double i = 0;
        double j = 0;
        double k = 0;
        double allotedSlideTime;
        double prevSlideTime;
        double prevAllotedTime;
        double nextAllotedTime;
        private Label secText;
        private Label minText;
        private Label hrText;
        ListBox lapList = new ListBox();


     
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            PowerPoint.Application objName = new PowerPoint.Application();

            objName.SlideShowNextSlide += ObjName_SlideShowNextSlide;
            objName.SlideShowBegin += ObjName_SlideShowBegin;
            objName.SlideShowEnd += ObjName_SlideShowEnd;

            

            s.Stop();
            secTimer.Stop();
            minTimer.Stop();
            hrTimer.Stop();
        }

        private void ObjName_SlideShowNextSlide(PowerPoint.SlideShowWindow Wn)
        {
            TimeSpan ts = s.Elapsed;
            TimeSpan LapTime = ts - LastBreakTime;
            LastBreakTime = ts;
            prevSlideTime = LapTime.TotalMilliseconds;

            ++lapCount;
            lapList.Items.Add(ts.ToString() + "," + prevSlideTime.ToString() + "," + prevAllotedTime.ToString());
            nextAllotedTime = (allotedSlideTime + (prevAllotedTime - prevSlideTime));

            string nextSlideTimeStr = nextAllotedTime.ToString(); //DEBUG CODE to show how much time next slide has
            MessageBox.Show(nextSlideTimeStr);
            prevAllotedTime = nextAllotedTime;
            
        }

        private void ObjName_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            s.Start();
            secTimer.Start();
            minTimer.Start();
            hrTimer.Start();
            
        }

        private void ObjName_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            if (lapCount < 0)
            {
                lapCount++;
            }
            else
            {
                TimeSpan ts = s.Elapsed;
                TimeSpan LapTime = ts - LastBreakTime;
                LastBreakTime = ts;
                prevSlideTime = LapTime.TotalMilliseconds;

                ++lapCount;
                lapList.Items.Add(ts.ToString() + "," + prevSlideTime.ToString() + "," + prevAllotedTime.ToString());
                s.Stop();
                secTimer.Stop();
                minTimer.Stop();
                hrTimer.Stop();
                var csv = new StringBuilder();
                var topLine = string.Format("{0},{1},{2},{3}", "Slide#", "CurrentTime", "SlideTimeUsed", "SlideTimeAlloted");
                csv.AppendLine(topLine);
                int lapc = 0;
                foreach (var item in lapList.Items)
                {
                    var newLine = string.Format("{0},{1}", lapc, item);
                    csv.AppendLine(newLine);
                    lapc++;
                }
                var baseLine = string.Format("{0},{1}", "Overall", s.Elapsed);
                csv.AppendLine(baseLine);
                System.IO.File.AppendAllText(sPath, csv.ToString());
                throw new NotImplementedException();
            }
                
           
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

        private void timeButton_Click(object sender, RibbonControlEventArgs e)
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
            prevAllotedTime = allotedSlideTime;
        }
    }
}
