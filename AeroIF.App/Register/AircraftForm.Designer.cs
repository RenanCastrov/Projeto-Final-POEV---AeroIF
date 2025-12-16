namespace AeroIF.App.Register
{
    partial class AircraftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AircraftForm));
            txtModel = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCapacity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCompany = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblRegisterHeader = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(719, 419);
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
            panel2.Controls.Add(lblRegisterHeader);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtCompany);
            panel2.Controls.Add(txtCapacity);
            panel2.Controls.Add(txtModel);
            panel2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            panel2.Size = new Size(525, 348);
            panel2.Controls.SetChildIndex(txtModel, 0);
            panel2.Controls.SetChildIndex(txtCapacity, 0);
            panel2.Controls.SetChildIndex(txtCompany, 0);
            panel2.Controls.SetChildIndex(txtId, 0);
            panel2.Controls.SetChildIndex(lblRegisterHeader, 0);
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.AutoCompleteMode = AutoCompleteMode.None;
            txtModel.AutoCompleteSource = AutoCompleteSource.None;
            txtModel.BackgroundImageLayout = ImageLayout.None;
            txtModel.CharacterCasing = CharacterCasing.Normal;
            txtModel.Depth = 0;
            txtModel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.HideSelection = true;
            txtModel.Hint = "Model";
            txtModel.LeadingIcon = null;
            txtModel.Location = new Point(12, 106);
            txtModel.MaxLength = 32767;
            txtModel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.PrefixSuffixText = null;
            txtModel.ReadOnly = false;
            txtModel.RightToLeft = RightToLeft.No;
            txtModel.SelectedText = "";
            txtModel.SelectionLength = 0;
            txtModel.SelectionStart = 0;
            txtModel.ShortcutsEnabled = true;
            txtModel.Size = new Size(398, 48);
            txtModel.TabIndex = 1;
            txtModel.TabStop = false;
            txtModel.TextAlign = HorizontalAlignment.Left;
            txtModel.TrailingIcon = null;
            txtModel.UseSystemPasswordChar = false;
            // 
            // txtCapacity
            // 
            txtCapacity.AnimateReadOnly = false;
            txtCapacity.AutoCompleteMode = AutoCompleteMode.None;
            txtCapacity.AutoCompleteSource = AutoCompleteSource.None;
            txtCapacity.BackgroundImageLayout = ImageLayout.None;
            txtCapacity.CharacterCasing = CharacterCasing.Normal;
            txtCapacity.Depth = 0;
            txtCapacity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCapacity.HideSelection = true;
            txtCapacity.Hint = "Capacity";
            txtCapacity.LeadingIcon = null;
            txtCapacity.Location = new Point(384, 181);
            txtCapacity.MaxLength = 32767;
            txtCapacity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.PasswordChar = '\0';
            txtCapacity.PrefixSuffixText = null;
            txtCapacity.ReadOnly = false;
            txtCapacity.RightToLeft = RightToLeft.No;
            txtCapacity.SelectedText = "";
            txtCapacity.SelectionLength = 0;
            txtCapacity.SelectionStart = 0;
            txtCapacity.ShortcutsEnabled = true;
            txtCapacity.Size = new Size(131, 48);
            txtCapacity.TabIndex = 2;
            txtCapacity.TabStop = false;
            txtCapacity.TextAlign = HorizontalAlignment.Left;
            txtCapacity.TrailingIcon = null;
            txtCapacity.UseSystemPasswordChar = false;
            // 
            // txtCompany
            // 
            txtCompany.AnimateReadOnly = false;
            txtCompany.AutoCompleteMode = AutoCompleteMode.None;
            txtCompany.AutoCompleteSource = AutoCompleteSource.None;
            txtCompany.BackgroundImageLayout = ImageLayout.None;
            txtCompany.CharacterCasing = CharacterCasing.Normal;
            txtCompany.Depth = 0;
            txtCompany.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCompany.HideSelection = true;
            txtCompany.Hint = "Company";
            txtCompany.LeadingIcon = null;
            txtCompany.Location = new Point(12, 181);
            txtCompany.MaxLength = 32767;
            txtCompany.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCompany.Name = "txtCompany";
            txtCompany.PasswordChar = '\0';
            txtCompany.PrefixSuffixText = null;
            txtCompany.ReadOnly = false;
            txtCompany.RightToLeft = RightToLeft.No;
            txtCompany.SelectedText = "";
            txtCompany.SelectionLength = 0;
            txtCompany.SelectionStart = 0;
            txtCompany.ShortcutsEnabled = true;
            txtCompany.Size = new Size(353, 48);
            txtCompany.TabIndex = 3;
            txtCompany.TabStop = false;
            txtCompany.TextAlign = HorizontalAlignment.Left;
            txtCompany.TrailingIcon = null;
            txtCompany.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(431, 106);
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
            txtId.Size = new Size(84, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // lblRegisterHeader
            // 
            lblRegisterHeader.AutoSize = true;
            lblRegisterHeader.BackColor = Color.Transparent;
            lblRegisterHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRegisterHeader.ForeColor = Color.FromArgb(10, 99, 155);
            lblRegisterHeader.Location = new Point(155, 27);
            lblRegisterHeader.Name = "lblRegisterHeader";
            lblRegisterHeader.Size = new Size(241, 20);
            lblRegisterHeader.TabIndex = 5;
            lblRegisterHeader.Text = "A new Aircraft will fly tomorrow!";
            // 
            // AircraftForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 483);
            MaximizeBox = false;
            Name = "AircraftForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AircraftForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCompany;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCapacity;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModel;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblRegisterHeader;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}