using AeroIF.App.Base;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;
using System.Xml.Linq;

namespace AeroIF.App.Register
{
    public partial class AircraftForm : BaseForm
    {
        private IBaseService<Aircraft> _aircraftService;
        private List<AircraftViewModel>? aircrafts;
        public AircraftForm()
        {
            InitializeComponent();
        }
        public AircraftForm(IBaseService<Aircraft> aircraftService) : this()
        {
            _aircraftService = aircraftService;

            this.tabControlRegister.SelectedIndexChanged += TabControlRegister_SelectedIndexChanged;

            PopulateGrid();
        }

        private void FormToObject(Aircraft aircraft)
        {
            aircraft.Model = txtModel.Text;
            aircraft.Company = txtCompany.Text;
            aircraft.Capacity = int.Parse(txtCapacity.Text);
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var aircraft = _aircraftService.GetById<Aircraft>(id);
                    FormToObject(aircraft);
                    aircraft = _aircraftService.Update<Aircraft, Aircraft, AircraftValidator>(aircraft);
                }
                else
                {
                    var aircraft = new Aircraft();
                    FormToObject(aircraft);
                    _aircraftService.Add<Aircraft, Aircraft, AircraftValidator>(aircraft);
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
                _aircraftService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            aircrafts = _aircraftService.Get<AircraftViewModel>().ToList();
            dataGridViewList.DataSource = aircrafts;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtModel.Text = record?.Cells["Model"].Value.ToString();
            txtCompany.Text = record?.Cells["Company"].Value.ToString();
            txtCapacity.Text = record?.Cells["Capacity"].Value.ToString();
        }

        private void AircraftForm_Load(object sender, EventArgs e)
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
