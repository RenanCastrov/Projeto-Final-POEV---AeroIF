using AeroIF.App.Infra;
using AeroIF.App.Register;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;
using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;

namespace AeroIF.App.Other
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private readonly IBaseService<User> _userService;
        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            User user = GetUser(txtLogin.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid user or password!", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!user.IsActive)
            {
                MessageBox.Show("Inactive User!", "IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.LoginDate = DateTime.Now;
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.User = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User? GetUser(string login, string password)
        {
            CheckRegisteredUser();
            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }

        private void CheckRegisteredUser()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Login = "admin",
                    Password = "Admin123",
                    Name = "Admnistrador do Sistema",
                    IsActive = true,
                    RegisterDate = DateTime.Now,
                    Email = "admin@gmail.com"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
