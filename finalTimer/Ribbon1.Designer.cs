namespace finalTimer
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ovrallTime = this.Factory.CreateRibbonEditBox();
            this.numSlidesBox = this.Factory.CreateRibbonEditBox();
            this.timeButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.physTimerButton = this.Factory.CreateRibbonToggleButton();
            this.box1 = this.Factory.CreateRibbonBox();
            this.hrTimer = new System.Windows.Forms.Timer(this.components);
            this.minTimer = new System.Windows.Forms.Timer(this.components);
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ovrallTime);
            this.group1.Items.Add(this.numSlidesBox);
            this.group1.Items.Add(this.timeButton);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // ovrallTime
            // 
            this.ovrallTime.Label = "Overall Pres. Time";
            this.ovrallTime.Name = "ovrallTime";
            this.ovrallTime.Text = null;
            // 
            // numSlidesBox
            // 
            this.numSlidesBox.Label = "  Number of Slides";
            this.numSlidesBox.Name = "numSlidesBox";
            this.numSlidesBox.Text = null;
            // 
            // timeButton
            // 
            this.timeButton.Label = "Submit";
            this.timeButton.Name = "timeButton";
            this.timeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.timeButton_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.physTimerButton);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // physTimerButton
            // 
            this.physTimerButton.Label = "Toggle Physical Timer";
            this.physTimerButton.Name = "physTimerButton";
            this.physTimerButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.physTimerButton_Click);
            // 
            // box1
            // 
            this.box1.Name = "box1";
            // 
            // hrTimer
            // 
            this.hrTimer.Interval = 3600000;
            // 
            // minTimer
            // 
            this.minTimer.Interval = 60000;
            // 
            // secTimer
            // 
            this.secTimer.Interval = 1000;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox ovrallTime;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox numSlidesBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton timeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton physTimerButton;
        public System.Windows.Forms.Timer hrTimer;
        public System.Windows.Forms.Timer minTimer;
        public System.Windows.Forms.Timer secTimer;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
