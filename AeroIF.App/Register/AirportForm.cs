using AeroIF.App.Base;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;

namespace AeroIF.App.Register
{
    public partial class AirportForm : BaseForm
    {
        private readonly IBaseService<Airport> _airportService;
        private readonly IBaseService<City> _cityService;
        private List<AirportViewModel>? airports;
        public AirportForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }
        public AirportForm(IBaseService<Airport> airportService, IBaseService<City> cityService) : this()
        {
            _airportService = airportService;
            _cityService = cityService;

            LoadCombo();

            this.tabControlRegister.SelectedIndexChanged += TabControlRegister_SelectedIndexChanged;

            PopulateGrid();
        }

        private void LoadCombo()
        {
            if (_cityService != null)
            {
                cmbCity.ValueMember = "Id";
                cmbCity.DisplayMember = "Name";
                cmbCity.DataSource = _cityService.Get<CityViewModel>().ToList();
            }
        }

        private void FormToObject(Airport airport)
        {
            airport.Name = txtName.Text;
            airport.Code = txtCode.Text;
            if (int.TryParse(cmbCity.SelectedValue.ToString(), out int cityId))
            {
                var city = _cityService.GetById<City>(cityId);
                airport.City = city;
            }
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var airport = _airportService.GetById<Airport>(id);
                    FormToObject(airport);
                    airport = _airportService.Update<Airport, Airport, AirportValidator>(airport);
                }
                else
                {
                    var airport = new Airport();
                    FormToObject(airport);
                    _airportService.Add<Airport, Airport, AirportValidator>(airport);
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
                _airportService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            if (_airportService == null)
            {
                return;
            }

            try
            {
                airports = _airportService.Get<AirportViewModel>().ToList();
                dataGridViewList.DataSource = airports;

                // Renomear colunas para melhor UX (Opcional)
                if (dataGridViewList.Columns.Contains("Id"))
                {
                    dataGridViewList.Columns["Id"]!.HeaderText = "ID";
                }
                if (dataGridViewList.Columns.Contains("Name"))
                {
                    dataGridViewList.Columns["Name"]!.HeaderText = "Name";
                }
                if (dataGridViewList.Columns.Contains("Code"))
                {
                    dataGridViewList.Columns["Code"]!.HeaderText = "Code";
                }
                if (dataGridViewList.Columns.Contains("CityName")) // Se você tiver esta coluna no ViewModel
                {
                    dataGridViewList.Columns["CityName"]!.HeaderText = "City";
                }

                // Ocultar a chave estrangeira
                if (dataGridViewList.Columns.Contains("CityId"))
                {
                    dataGridViewList.Columns["CityId"]!.Visible = false;
                }

                dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao popular a grade de aeroportos: {ex.Message}", @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewList.DataSource = null;
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtCode.Text = record?.Cells["Code"].Value.ToString();
            cmbCity.SelectedValue = record?.Cells["CityId"].Value;
        }

        private void AirportForm_Load(object sender, EventArgs e)
        {

        }

        private void TabControlRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            // A aba 'List' (tabPageList) é a segunda aba, que corresponde ao índice 1.
            if (this.tabControlRegister.SelectedIndex == 1)
            {
                PopulateGrid();
            }
        }
    }
}
