namespace AeroIF.App.Register
{
    partial class CityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            lblRegisterHeader = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtState = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCountry = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(0, 62);
            tabControlRegister.Size = new Size(721, 419);
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
            panel2.Controls.Add(txtCountry);
            panel2.Controls.Add(txtState);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(lblRegisterHeader);
            panel2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            panel2.Size = new Size(527, 348);
            panel2.Controls.SetChildIndex(lblRegisterHeader, 0);
            panel2.Controls.SetChildIndex(txtName, 0);
            panel2.Controls.SetChildIndex(txtId, 0);
            panel2.Controls.SetChildIndex(txtState, 0);
            panel2.Controls.SetChildIndex(txtCountry, 0);
            // 
            // lblRegisterHeader
            // 
            lblRegisterHeader.AutoSize = true;
            lblRegisterHeader.BackColor = Color.Transparent;
            lblRegisterHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRegisterHeader.ForeColor = Color.FromArgb(10, 99, 155);
            lblRegisterHeader.Location = new Point(176, 27);
            lblRegisterHeader.Name = "lblRegisterHeader";
            lblRegisterHeader.Size = new Size(173, 20);
            lblRegisterHeader.TabIndex = 1;
            lblRegisterHeader.Text = "A new City on the map!";
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
            txtName.Location = new Point(12, 97);
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
            txtName.Size = new Size(324, 48);
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
            txtId.Location = new Point(444, 97);
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
            txtId.Size = new Size(73, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtState
            // 
            txtState.AnimateReadOnly = false;
            txtState.AutoCompleteMode = AutoCompleteMode.None;
            txtState.AutoCompleteSource = AutoCompleteSource.None;
            txtState.BackgroundImageLayout = ImageLayout.None;
            txtState.CharacterCasing = CharacterCasing.Normal;
            txtState.Depth = 0;
            txtState.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtState.HideSelection = true;
            txtState.Hint = "State";
            txtState.LeadingIcon = null;
            txtState.Location = new Point(342, 97);
            txtState.MaxLength = 32767;
            txtState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtState.Name = "txtState";
            txtState.PasswordChar = '\0';
            txtState.PrefixSuffixText = null;
            txtState.ReadOnly = false;
            txtState.RightToLeft = RightToLeft.No;
            txtState.SelectedText = "";
            txtState.SelectionLength = 0;
            txtState.SelectionStart = 0;
            txtState.ShortcutsEnabled = true;
            txtState.Size = new Size(87, 48);
            txtState.TabIndex = 4;
            txtState.TabStop = false;
            txtState.TextAlign = HorizontalAlignment.Left;
            txtState.TrailingIcon = null;
            txtState.UseSystemPasswordChar = false;
            // 
            // txtCountry
            // 
            txtCountry.AnimateReadOnly = false;
            txtCountry.AutoCompleteMode = AutoCompleteMode.None;
            txtCountry.AutoCompleteSource = AutoCompleteSource.None;
            txtCountry.BackgroundImageLayout = ImageLayout.None;
            txtCountry.CharacterCasing = CharacterCasing.Normal;
            txtCountry.Depth = 0;
            txtCountry.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCountry.HideSelection = true;
            txtCountry.Hint = "Country";
            txtCountry.LeadingIcon = null;
            txtCountry.Location = new Point(12, 165);
            txtCountry.MaxLength = 32767;
            txtCountry.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCountry.Name = "txtCountry";
            txtCountry.PasswordChar = '\0';
            txtCountry.PrefixSuffixText = null;
            txtCountry.ReadOnly = false;
            txtCountry.RightToLeft = RightToLeft.No;
            txtCountry.SelectedText = "";
            txtCountry.SelectionLength = 0;
            txtCountry.SelectionStart = 0;
            txtCountry.ShortcutsEnabled = true;
            txtCountry.Size = new Size(505, 48);
            txtCountry.TabIndex = 5;
            txtCountry.TabStop = false;
            txtCountry.TextAlign = HorizontalAlignment.Left;
            txtCountry.TrailingIcon = null;
            txtCountry.UseSystemPasswordChar = false;
            // 
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 481);
            Name = "CityForm";
            Text = "City Form";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblRegisterHeader;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCountry;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtState;
    }
}