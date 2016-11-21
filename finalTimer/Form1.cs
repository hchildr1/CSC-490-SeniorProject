using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace finalTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PowerPoint.Application objName = new PowerPoint.Application();

            
            objName.SlideShowBegin += ObjName_SlideShowBegin;
            objName.SlideShowEnd += ObjName_SlideShowEnd;

            secTimer.Stop();
            minTimer.Stop();
            hrTimer1.Stop();
            
        }
        double i = 0;
        double j = 0;
        double k = 0;

        private void ObjName_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            
            secTimer.Start();
            minTimer.Start();
            hrTimer1.Start();

        }



        private void ObjName_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            secTimer.Stop();
            minTimer.Stop();
            hrTimer1.Stop();
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

        private void hrTimer1_Tick(object sender, EventArgs e)
        {

            k++;
            hrText.Text = k.ToString("00");
            if (k == 24)
            {
                k = -1;
            }
        }
    }
}
