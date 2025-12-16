namespace AeroIF.App.Register
{
    partial class PilotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilotForm));
            lblRegisterHeader = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLicense = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(0, 63);
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
            panel2.Controls.Add(txtLicense);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(lblRegisterHeader);
            panel2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            panel2.Controls.SetChildIndex(lblRegisterHeader, 0);
            panel2.Controls.SetChildIndex(txtName, 0);
            panel2.Controls.SetChildIndex(txtId, 0);
            panel2.Controls.SetChildIndex(txtLicense, 0);
            // 
            // lblRegisterHeader
            // 
            lblRegisterHeader.AutoSize = true;
            lblRegisterHeader.BackColor = Color.Transparent;
            lblRegisterHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRegisterHeader.ForeColor = Color.FromArgb(10, 99, 155);
            lblRegisterHeader.Location = new Point(156, 27);
            lblRegisterHeader.Name = "lblRegisterHeader";
            lblRegisterHeader.Size = new Size(232, 20);
            lblRegisterHeader.TabIndex = 1;
            lblRegisterHeader.Text = "A new Pilot is coming on board!";
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(12, 104);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(399, 48);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(433, 104);
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
            txtId.Size = new Size(83, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtLicense
            // 
            txtLicense.AnimateReadOnly = false;
            txtLicense.AutoCompleteMode = AutoCompleteMode.None;
            txtLicense.AutoCompleteSource = AutoCompleteSource.None;
            txtLicense.BackgroundImageLayout = ImageLayout.None;
            txtLicense.CharacterCasing = CharacterCasing.Normal;
            txtLicense.Depth = 0;
            txtLicense.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLicense.HideSelection = true;
            txtLicense.Hint = "License";
            txtLicense.LeadingIcon = null;
            txtLicense.Location = new Point(12, 179);
            txtLicense.MaxLength = 32767;
            txtLicense.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLicense.Name = "txtLicense";
            txtLicense.PasswordChar = '\0';
            txtLicense.PrefixSuffixText = null;
            txtLicense.ReadOnly = false;
            txtLicense.RightToLeft = RightToLeft.No;
            txtLicense.SelectedText = "";
            txtLicense.SelectionLength = 0;
            txtLicense.SelectionStart = 0;
            txtLicense.ShortcutsEnabled = true;
            txtLicense.Size = new Size(399, 48);
            txtLicense.TabIndex = 4;
            txtLicense.TabStop = false;
            txtLicense.TextAlign = HorizontalAlignment.Left;
            txtLicense.TrailingIcon = null;
            txtLicense.UseSystemPasswordChar = false;
            // 
            // PilotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 482);
            MaximizeBox = false;
            Name = "PilotForm";
            Text = "PilotForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel lblRegisterHeader;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLicense;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
    }
}