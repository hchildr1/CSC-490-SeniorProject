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

        
        double allotedSlideTime;
        double prevSlideTime;
        double prevAllotedTime;
        double nextAllotedTime;
        double percentageUsed;
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
            if (lapCount == 0)
            {
                lapCount++;
            }else
            {
                TimeSpan ts = s.Elapsed;
                TimeSpan LapTime = ts - LastBreakTime;
                LastBreakTime = ts;
                prevSlideTime = LapTime.TotalMilliseconds;
                double prevSlideTimeSeconds = LapTime.TotalSeconds;
               

                ++lapCount;
                lapList.Items.Add(ts.ToString() + "," + prevSlideTimeSeconds.ToString() + "," + prevAllotedTime.ToString() + "," + percentageUsed.ToString() + "%");
                nextAllotedTime = (allotedSlideTime + (prevAllotedTime - prevSlideTime));
                double nextAllotedTimeSeconds = (nextAllotedTime / 1000);
                string nextSlideTimeStr = nextAllotedTimeSeconds.ToString(); //DEBUG CODE to show how much time next slide has
                MessageBox.Show(nextSlideTimeStr + " seconds");
                prevAllotedTime = nextAllotedTime;

            }
            
            
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
            
            
            
                TimeSpan ts = s.Elapsed;
                TimeSpan LapTime = ts - LastBreakTime;
                LastBreakTime = ts;
                prevSlideTime = LapTime.TotalMilliseconds;
                double prevSlideTimeSeconds = LapTime.TotalSeconds;
                percentageUsed = (prevSlideTime / prevAllotedTime);


                ++lapCount;
                lapList.Items.Add(ts.ToString() + "," + prevSlideTimeSeconds.ToString() + "," + prevAllotedTime.ToString() + "," + percentageUsed.ToString() + "%" );
                s.Stop();
                secTimer.Stop();
                minTimer.Stop();
                hrTimer.Stop();
                var csv = new StringBuilder();
                var topLine = string.Format("{0},{1},{2},{3},{4}", "Slide #", "Overall Time", "Time Used On Slide (In Seconds)", "Time Allotted For Slide","% Over or Under Allotted");
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

        private void physTimerButton_Click(object sender, RibbonControlEventArgs e)
        {
            Form1 physTimer = new Form1();
            physTimer.Show();
            physTimer.TopMost = true;
        }

    }

}
