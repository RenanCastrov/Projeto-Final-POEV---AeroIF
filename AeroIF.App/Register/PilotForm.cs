using AeroIF.App.Base;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;
using Microsoft.VisualBasic.ApplicationServices;

namespace AeroIF.App.Register
{
    public partial class PilotForm : BaseForm
    {
        private IBaseService<Pilot> _pilotService;
        private List<PilotViewModel>? pilots;
        public PilotForm()
        {
            InitializeComponent();
        }
        public PilotForm(IBaseService<Pilot> pilotService) : this()
        {
            _pilotService = pilotService;

            this.tabControlRegister.SelectedIndexChanged += TabControlRegister_SelectedIndexChanged;

            PopulateGrid();
        }

        private void FormToObject(Pilot pilot)
        {
            pilot.Name = txtName.Text;
            pilot.License = txtLicense.Text;
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var pilot = _pilotService.GetById<Pilot>(id);
                    FormToObject(pilot);
                    pilot = _pilotService.Update<Pilot, Pilot, PilotValidator>(pilot);
                }
                else
                {
                    var pilot = new Pilot();
                    FormToObject(pilot);
                    _pilotService.Add<Pilot, Pilot, PilotValidator>(pilot);
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
                _pilotService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            pilots = _pilotService.Get<PilotViewModel>().ToList();
            dataGridViewList.DataSource = pilots;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtLicense.Text = record?.Cells["License"].Value.ToString();
        }

        private void PilotForm_Load(object sender, EventArgs e)
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
