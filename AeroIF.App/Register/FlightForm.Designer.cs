namespace AeroIF.App.Register
{
    partial class FlightForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightForm));
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            cmbStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbAircraft = new ReaLTaiizor.Controls.MaterialComboBox();
            cmbPilot = new ReaLTaiizor.Controls.MaterialComboBox();
            cmbOriginAirport = new ReaLTaiizor.Controls.MaterialComboBox();
            cmbDestinyAirport = new ReaLTaiizor.Controls.MaterialComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(0, 62);
            tabControlRegister.Size = new Size(723, 419);
            tabControlRegister.TabButtonHoverState.BorderColor = Color.Empty;
            tabControlRegister.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tabControlRegister.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tabControlRegister.TabButtonHoverState.ForeColor = Color.White;
            tabControlRegister.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControlRegister.TabButtonIdleState.BorderColor = Color.Empty;
            tabControlRegister.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tabControlRegister.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tabControlRegister.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tabControlRegister.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControlRegister.TabButtonImageAlign = HorizontalAlignment.Center;
            tabControlRegister.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControlRegister.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tabControlRegister.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tabControlRegister.TabButtonSelectedState.ForeColor = Color.White;
            tabControlRegister.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbDestinyAirport);
            panel2.Controls.Add(cmbOriginAirport);
            panel2.Controls.Add(cmbPilot);
            panel2.Controls.Add(cmbAircraft);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(dungeonHeaderLabel1);
            panel2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            panel2.Size = new Size(529, 348);
            panel2.Controls.SetChildIndex(dungeonHeaderLabel1, 0);
            panel2.Controls.SetChildIndex(cmbStatus, 0);
            panel2.Controls.SetChildIndex(txtId, 0);
            panel2.Controls.SetChildIndex(cmbAircraft, 0);
            panel2.Controls.SetChildIndex(cmbPilot, 0);
            panel2.Controls.SetChildIndex(cmbOriginAirport, 0);
            panel2.Controls.SetChildIndex(cmbDestinyAirport, 0);
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(10, 99, 155);
            dungeonHeaderLabel1.Location = new Point(166, 27);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(193, 20);
            dungeonHeaderLabel1.TabIndex = 1;
            dungeonHeaderLabel1.Text = "It's time to set up a Flight!";
            // 
            // cmbStatus
            // 
            cmbStatus.AutoResize = false;
            cmbStatus.BackColor = Color.FromArgb(255, 255, 255);
            cmbStatus.Depth = 0;
            cmbStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cmbStatus.DropDownHeight = 174;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownWidth = 121;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Hint = "Status";
            cmbStatus.IntegralHeight = false;
            cmbStatus.ItemHeight = 43;
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "On Time", "Delayed", "Cancelled", "Diverted", "Departed", "Arrived" });
            cmbStatus.Location = new Point(12, 93);
            cmbStatus.MaxDropDownItems = 4;
            cmbStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(402, 49);
            cmbStatus.StartIndex = 0;
            cmbStatus.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.LeadingIcon = (Image)resources.GetObject("txtId.LeadingIcon");
            txtId.Location = new Point(421, 94);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(98, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cmbAircraft
            // 
            cmbAircraft.AutoResize = false;
            cmbAircraft.BackColor = Color.FromArgb(255, 255, 255);
            cmbAircraft.Depth = 0;
            cmbAircraft.DrawMode = DrawMode.OwnerDrawVariable;
            cmbAircraft.DropDownHeight = 174;
            cmbAircraft.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAircraft.DropDownWidth = 121;
            cmbAircraft.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbAircraft.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbAircraft.FormattingEnabled = true;
            cmbAircraft.Hint = "Aircraft";
            cmbAircraft.IntegralHeight = false;
            cmbAircraft.ItemHeight = 43;
            cmbAircraft.Location = new Point(12, 157);
            cmbAircraft.MaxDropDownItems = 4;
            cmbAircraft.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbAircraft.Name = "cmbAircraft";
            cmbAircraft.Size = new Size(249, 49);
            cmbAircraft.StartIndex = 0;
            cmbAircraft.TabIndex = 5;
            // 
            // cmbPilot
            // 
            cmbPilot.AutoResize = false;
            cmbPilot.BackColor = Color.FromArgb(255, 255, 255);
            cmbPilot.Depth = 0;
            cmbPilot.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPilot.DropDownHeight = 174;
            cmbPilot.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPilot.DropDownWidth = 121;
            cmbPilot.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPilot.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPilot.FormattingEnabled = true;
            cmbPilot.Hint = "Pilot";
            cmbPilot.IntegralHeight = false;
            cmbPilot.ItemHeight = 43;
            cmbPilot.Location = new Point(270, 157);
            cmbPilot.MaxDropDownItems = 4;
            cmbPilot.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbPilot.Name = "cmbPilot";
            cmbPilot.Size = new Size(249, 49);
            cmbPilot.StartIndex = 0;
            cmbPilot.TabIndex = 6;
            // 
            // cmbOriginAirport
            // 
            cmbOriginAirport.AutoResize = false;
            cmbOriginAirport.BackColor = Color.FromArgb(255, 255, 255);
            cmbOriginAirport.Depth = 0;
            cmbOriginAirport.DrawMode = DrawMode.OwnerDrawVariable;
            cmbOriginAirport.DropDownHeight = 174;
            cmbOriginAirport.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOriginAirport.DropDownWidth = 121;
            cmbOriginAirport.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbOriginAirport.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbOriginAirport.FormattingEnabled = true;
            cmbOriginAirport.Hint = "Origin Airport";
            cmbOriginAirport.IntegralHeight = false;
            cmbOriginAirport.ItemHeight = 43;
            cmbOriginAirport.Location = new Point(12, 225);
            cmbOriginAirport.MaxDropDownItems = 4;
            cmbOriginAirport.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbOriginAirport.Name = "cmbOriginAirport";
            cmbOriginAirport.Size = new Size(249, 49);
            cmbOriginAirport.StartIndex = 0;
            cmbOriginAirport.TabIndex = 7;
            // 
            // cmbDestinyAirport
            // 
            cmbDestinyAirport.AutoResize = false;
            cmbDestinyAirport.BackColor = Color.FromArgb(255, 255, 255);
            cmbDestinyAirport.Depth = 0;
            cmbDestinyAirport.DrawMode = DrawMode.OwnerDrawVariable;
            cmbDestinyAirport.DropDownHeight = 174;
            cmbDestinyAirport.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestinyAirport.DropDownWidth = 121;
            cmbDestinyAirport.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbDestinyAirport.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbDestinyAirport.FormattingEnabled = true;
            cmbDestinyAirport.Hint = "Destiny Airport";
            cmbDestinyAirport.IntegralHeight = false;
            cmbDestinyAirport.ItemHeight = 43;
            cmbDestinyAirport.Location = new Point(270, 225);
            cmbDestinyAirport.MaxDropDownItems = 4;
            cmbDestinyAirport.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbDestinyAirport.Name = "cmbDestinyAirport";
            cmbDestinyAirport.Size = new Size(249, 49);
            cmbDestinyAirport.StartIndex = 0;
            cmbDestinyAirport.TabIndex = 8;
            // 
            // FlightForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 481);
            MaximizeBox = false;
            Name = "FlightForm";
            Text = "Flight Form";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cmbStatus;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox cmbDestinyAirport;
        private ReaLTaiizor.Controls.MaterialComboBox cmbOriginAirport;
        private ReaLTaiizor.Controls.MaterialComboBox cmbPilot;
        private ReaLTaiizor.Controls.MaterialComboBox cmbAircraft;
    }
}