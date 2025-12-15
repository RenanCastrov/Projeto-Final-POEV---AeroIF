namespace AeroIF.App.Register
{
    partial class AirportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirportForm));
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCode = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbCity = new ReaLTaiizor.Controls.MaterialComboBox();
            lblRegisterHeader = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(737, 419);
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
            panel2.Controls.Add(cmbCity);
            panel2.Controls.Add(txtCode);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtName);
            panel2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            panel2.Size = new Size(543, 348);
            panel2.Controls.SetChildIndex(txtName, 0);
            panel2.Controls.SetChildIndex(txtId, 0);
            panel2.Controls.SetChildIndex(txtCode, 0);
            panel2.Controls.SetChildIndex(cmbCity, 0);
            panel2.Controls.SetChildIndex(lblRegisterHeader, 0);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(12, 103);
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
            txtName.Size = new Size(416, 48);
            txtName.TabIndex = 1;
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
            txtId.Location = new Point(445, 103);
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
            txtId.Size = new Size(88, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCode
            // 
            txtCode.AnimateReadOnly = false;
            txtCode.AutoCompleteMode = AutoCompleteMode.None;
            txtCode.AutoCompleteSource = AutoCompleteSource.None;
            txtCode.BackgroundImageLayout = ImageLayout.None;
            txtCode.CharacterCasing = CharacterCasing.Normal;
            txtCode.Depth = 0;
            txtCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCode.HideSelection = true;
            txtCode.Hint = "Code";
            txtCode.LeadingIcon = null;
            txtCode.Location = new Point(12, 179);
            txtCode.MaxLength = 32767;
            txtCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '\0';
            txtCode.PrefixSuffixText = null;
            txtCode.ReadOnly = false;
            txtCode.RightToLeft = RightToLeft.No;
            txtCode.SelectedText = "";
            txtCode.SelectionLength = 0;
            txtCode.SelectionStart = 0;
            txtCode.ShortcutsEnabled = true;
            txtCode.Size = new Size(195, 48);
            txtCode.TabIndex = 3;
            txtCode.TabStop = false;
            txtCode.TextAlign = HorizontalAlignment.Left;
            txtCode.TrailingIcon = null;
            txtCode.UseSystemPasswordChar = false;
            // 
            // cmbCity
            // 
            cmbCity.AutoResize = false;
            cmbCity.BackColor = Color.FromArgb(255, 255, 255);
            cmbCity.Depth = 0;
            cmbCity.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCity.DropDownHeight = 174;
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.DropDownWidth = 121;
            cmbCity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCity.FormattingEnabled = true;
            cmbCity.Hint = "City";
            cmbCity.IntegralHeight = false;
            cmbCity.ItemHeight = 43;
            cmbCity.Location = new Point(225, 179);
            cmbCity.MaxDropDownItems = 4;
            cmbCity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(308, 49);
            cmbCity.StartIndex = 0;
            cmbCity.TabIndex = 4;
            // 
            // lblRegisterHeader
            // 
            lblRegisterHeader.AutoSize = true;
            lblRegisterHeader.BackColor = Color.Transparent;
            lblRegisterHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRegisterHeader.ForeColor = Color.FromArgb(10, 99, 155);
            lblRegisterHeader.Location = new Point(182, 27);
            lblRegisterHeader.Name = "lblRegisterHeader";
            lblRegisterHeader.Size = new Size(188, 20);
            lblRegisterHeader.TabIndex = 5;
            lblRegisterHeader.Text = "A new Airport in the City!";
            // 
            // AirportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 483);
            Name = "AirportForm";
            Text = "Airport Form";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblRegisterHeader;
        private ReaLTaiizor.Controls.MaterialComboBox cmbCity;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCode;
    }
}