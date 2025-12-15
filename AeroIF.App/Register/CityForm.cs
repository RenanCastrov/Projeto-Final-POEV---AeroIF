using AeroIF.App.Base;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;

namespace AeroIF.App.Register
{
    public partial class CityForm : BaseForm
    {
        private IBaseService<City> _cityService;
        private List<CityViewModel>? cities;
        public CityForm()
        {
            InitializeComponent();
        }
        public CityForm(IBaseService<City> cityService) : this()
        {
            _cityService = cityService;

            this.tabControlRegister.SelectedIndexChanged += TabControlRegister_SelectedIndexChanged;

            PopulateGrid();
        }

        private void FormToObject(City city)
        {
            city.Name = txtName.Text;
            city.State = txtState.Text;
            city.Country = txtCountry.Text;
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var city = _cityService.GetById<City>(id);
                    FormToObject(city);
                    city = _cityService.Update<City, City, CityValidator>(city);
                }
                else
                {
                    var city = new City();
                    FormToObject(city);
                    _cityService.Add<City, City, CityValidator>(city);
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
                _cityService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            cities = _cityService.Get<CityViewModel>().ToList();
            dataGridViewList.DataSource = cities;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            txtName.Text = record?.Cells["Name"].Value.ToString();
            txtState.Text = record?.Cells["State"].Value.ToString();
            txtCountry.Text = record?.Cells["Country"].Value.ToString();
        }

        private void CityForm_Load(object sender, EventArgs e)
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
