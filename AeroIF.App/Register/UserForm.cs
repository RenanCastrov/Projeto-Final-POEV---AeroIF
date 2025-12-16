using AeroIF.App.Base;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;

namespace AeroIF.App.Register
{
    public partial class UserForm : BaseForm
    {
        private IBaseService<User> _userService;
        private List<UserViewModel>? users;

        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(IBaseService<User> userService) : this()
        {
            _userService = userService;

            this.tabControlRegister.SelectedIndexChanged += TabControlRegister_SelectedIndexChanged;

            PopulateGrid();
        }

        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.IsActive = chkActive.Checked;
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var user = _userService.GetById<User>(id);
                    FormToObject(user);
                    user.RegisterDate = DateTime.Now;
                    user.LoginDate = DateTime.Now;
                    user = _userService.Update<User, User, UserValidator>(user);
                }
                else
                {
                    var user = new User();
                    FormToObject(user);
                    user.RegisterDate = DateTime.Now;
                    user.LoginDate = DateTime.Now;
                    _userService.Add<User, User, UserValidator>(user);
                }
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _userService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            users = _userService.Get<UserViewModel>().ToList();
            dataGridViewList.DataSource = users;
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtLogin.Text = record?.Cells["Login"].Value.ToString();
            txtPassword.Text = record?.Cells["Password"].Value.ToString();
            txtEmail.Text = record?.Cells["Email"].Value.ToString();
            chkActive.Checked = (bool)(record?.Cells["IsActive"].Value ?? false);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void TabControlRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlRegister.SelectedIndex == 1)
            {
                PopulateGrid();
            }
        }

    }
}
