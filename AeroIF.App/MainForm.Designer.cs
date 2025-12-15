namespace AeroIF.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            parrotToolStrip1 = new ReaLTaiizor.Controls.ParrotToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            userToolStripMenuItem = new ToolStripMenuItem();
            pilotToolStripMenuItem = new ToolStripMenuItem();
            cityToolStripMenuItem = new ToolStripMenuItem();
            airportToolStripMenuItem = new ToolStripMenuItem();
            aircraftToolStripMenuItem = new ToolStripMenuItem();
            flightToolStripMenuItem = new ToolStripMenuItem();
            toolStripAboutButton = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            parrotToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 48);
            label1.Size = new Size(0, 63);
            label1.TabIndex = 2;
            // 
            // parrotToolStrip1
            // 
            parrotToolStrip1.BackColor = Color.Transparent;
            parrotToolStrip1.BackgroundImage = (Image)resources.GetObject("parrotToolStrip1.BackgroundImage");
            parrotToolStrip1.BorderColor = Color.Green;
            parrotToolStrip1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotToolStrip1.ForeColor = Color.Black;
            parrotToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            parrotToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripAboutButton, toolStripButton2 });
            parrotToolStrip1.Location = new Point(0, 63);
            parrotToolStrip1.Name = "parrotToolStrip1";
            parrotToolStrip1.Size = new Size(891, 26);
            parrotToolStrip1.TabIndex = 6;
            parrotToolStrip1.Text = "parrotToolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, pilotToolStripMenuItem, cityToolStripMenuItem, airportToolStripMenuItem, aircraftToolStripMenuItem, flightToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Padding = new Padding(0, 0, 1, 0);
            toolStripSplitButton1.Size = new Size(75, 23);
            toolStripSplitButton1.Text = "Register";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Image = (Image)resources.GetObject("userToolStripMenuItem.Image");
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(124, 24);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // pilotToolStripMenuItem
            // 
            pilotToolStripMenuItem.Image = (Image)resources.GetObject("pilotToolStripMenuItem.Image");
            pilotToolStripMenuItem.Name = "pilotToolStripMenuItem";
            pilotToolStripMenuItem.Size = new Size(124, 24);
            pilotToolStripMenuItem.Text = "Pilot";
            pilotToolStripMenuItem.Click += pilotToolStripMenuItem_Click;
            // 
            // cityToolStripMenuItem
            // 
            cityToolStripMenuItem.Image = (Image)resources.GetObject("cityToolStripMenuItem.Image");
            cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            cityToolStripMenuItem.Size = new Size(124, 24);
            cityToolStripMenuItem.Text = "City";
            cityToolStripMenuItem.Click += cityToolStripMenuItem_Click;
            // 
            // airportToolStripMenuItem
            // 
            airportToolStripMenuItem.Image = (Image)resources.GetObject("airportToolStripMenuItem.Image");
            airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            airportToolStripMenuItem.Size = new Size(124, 24);
            airportToolStripMenuItem.Text = "Airport";
            airportToolStripMenuItem.Click += airportToolStripMenuItem_Click;
            // 
            // aircraftToolStripMenuItem
            // 
            aircraftToolStripMenuItem.Image = (Image)resources.GetObject("aircraftToolStripMenuItem.Image");
            aircraftToolStripMenuItem.Name = "aircraftToolStripMenuItem";
            aircraftToolStripMenuItem.Size = new Size(124, 24);
            aircraftToolStripMenuItem.Text = "Aircraft";
            aircraftToolStripMenuItem.Click += aircraftToolStripMenuItem_Click;
            // 
            // flightToolStripMenuItem
            // 
            flightToolStripMenuItem.Image = (Image)resources.GetObject("flightToolStripMenuItem.Image");
            flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            flightToolStripMenuItem.Size = new Size(124, 24);
            flightToolStripMenuItem.Text = "Flight";
            flightToolStripMenuItem.Click += flightToolStripMenuItem_Click;
            // 
            // toolStripAboutButton
            // 
            toolStripAboutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripAboutButton.Image = (Image)resources.GetObject("toolStripAboutButton.Image");
            toolStripAboutButton.ImageTransparentColor = Color.Magenta;
            toolStripAboutButton.Name = "toolStripAboutButton";
            toolStripAboutButton.Size = new Size(71, 23);
            toolStripAboutButton.Text = "About Us";
            toolStripAboutButton.Click += toolStripAboutButton_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(46, 23);
            toolStripButton2.Text = "Close";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(891, 590);
            Controls.Add(parrotToolStrip1);
            Controls.Add(label1);
            ForeColor = SystemColors.HotTrack;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainForm";
            Sizable = false;
            Text = "AeroIF - Registration and Management Portal";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            parrotToolStrip1.ResumeLayout(false);
            parrotToolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ReaLTaiizor.Controls.ParrotToolStrip parrotToolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem pilotToolStripMenuItem;
        private ToolStripMenuItem cityToolStripMenuItem;
        private ToolStripMenuItem airportToolStripMenuItem;
        private ToolStripMenuItem aircraftToolStripMenuItem;
        private ToolStripMenuItem flightToolStripMenuItem;
        private ToolStripButton toolStripAboutButton;
        private ToolStripButton toolStripButton2;
    }
}
