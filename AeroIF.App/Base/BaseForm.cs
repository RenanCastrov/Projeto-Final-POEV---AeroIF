using Guna.UI2.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace AeroIF.App.Base
{
    public partial class BaseForm : MaterialSkin.Controls.MaterialForm
    {
        #region Variables
        protected bool isEditMode = false;
        #endregion
        #region Constructor Method
        public BaseForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                // Primary: Define a cor da Barra de Título. Use um tom de Verde (Green 700 e 800 são boas escolhas)
                Primary.Green700,
                Primary.Green800,
                // LightPrimary: Tom mais claro usado em alguns elementos de fundo
                Primary.Green500,
                // Accent: Define a cor de destaque (botões, sliders, etc.)
                Accent.LightGreen200,
                // TextShade: Cor do texto (WHITE ou BLACK)
                TextShade.WHITE
            );
        }
        #endregion
        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", @"AeroIF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete?", @"AeroIF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                    Delete(id);
                    PopulateGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Please, select any row!", @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        #endregion
        #region Methods
        protected void ClearFields()
        {
            isEditMode = false;
            foreach (var control in panel2.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
                if (control is ReaLTaiizor.Controls.MaterialCheckBox checkBox)
                    checkBox.Checked = false;
            }
        }

        public virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabPageRegister.Focus();
        }

        protected virtual void Save()
        {

        }

        protected virtual void Delete(int id)
        {

        }

        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                isEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                tabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show(@"Please, select any row!", @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }

        protected virtual void PopulateGrid()
        {

        }
        #endregion
        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void tabControlRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
