namespace AeroIF.App.Register
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkActive = new ReaLTaiizor.Controls.MaterialCheckBox();
            lblRegisterHeader = new ReaLTaiizor.Controls.DungeonHeaderLabel();
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
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(chkActive);
            panel2.Controls.Add(lblRegisterHeader);
            panel2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            panel2.Controls.SetChildIndex(lblRegisterHeader, 0);
            panel2.Controls.SetChildIndex(chkActive, 0);
            panel2.Controls.SetChildIndex(txtPassword, 0);
            panel2.Controls.SetChildIndex(txtLogin, 0);
            panel2.Controls.SetChildIndex(txtEmail, 0);
            panel2.Controls.SetChildIndex(txtId, 0);
            panel2.Controls.SetChildIndex(txtName, 0);
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
            txtName.Location = new Point(12, 62);
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
            txtId.Location = new Point(429, 62);
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
            txtId.Size = new Size(87, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(12, 116);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(504, 48);
            txtEmail.TabIndex = 3;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.Hint = "Login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(12, 170);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(245, 48);
            txtLogin.TabIndex = 4;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(271, 170);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(245, 48);
            txtPassword.TabIndex = 5;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Depth = 0;
            chkActive.Location = new Point(206, 258);
            chkActive.Margin = new Padding(0);
            chkActive.MouseLocation = new Point(-1, -1);
            chkActive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkActive.Name = "chkActive";
            chkActive.ReadOnly = false;
            chkActive.Ripple = true;
            chkActive.Size = new Size(113, 37);
            chkActive.TabIndex = 1;
            chkActive.Text = "Active User";
            chkActive.UseAccentColor = false;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // lblRegisterHeader
            // 
            lblRegisterHeader.AutoSize = true;
            lblRegisterHeader.BackColor = Color.Transparent;
            lblRegisterHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRegisterHeader.ForeColor = Color.FromArgb(10, 99, 155);
            lblRegisterHeader.Location = new Point(176, 13);
            lblRegisterHeader.Name = "lblRegisterHeader";
            lblRegisterHeader.Size = new Size(185, 20);
            lblRegisterHeader.TabIndex = 1;
            lblRegisterHeader.Text = "Let's register a new User!";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 482);
            MinimumSize = new Size(720, 0);
            Name = "UserForm";
            Text = "User Form";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialCheckBox chkActive;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblRegisterHeader;
    }
}