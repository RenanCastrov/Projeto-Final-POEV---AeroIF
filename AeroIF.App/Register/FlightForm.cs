using AeroIF.App.Base;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Service.Validators;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AeroIF.App.Register
{
    public partial class FlightForm : BaseForm
    {
        private readonly IBaseService<Flight> _flightService;
        private readonly IBaseService<Pilot> _pilotService;
        private readonly IBaseService<Airport> _airportService;
        private readonly IBaseService<Aircraft> _aircraftService;

        private List<FlightViewModel>? flights;
        public FlightForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }
        public FlightForm(IBaseService<Flight> flightService, IBaseService<Pilot> pilotService, IBaseService<Airport> airportService, IBaseService<Aircraft> aircraftService) : this()
        {
            _flightService = flightService;
            _pilotService = pilotService;
            _airportService = airportService;
            _aircraftService = aircraftService;

            LoadCombo();

            this.tabControlRegister.SelectedIndexChanged += TabControlRegister_SelectedIndexChanged;
        }

        private void LoadCombo()
        {
            if (_pilotService != null)
            {
                cmbPilot.ValueMember = "Id";
                cmbPilot.DisplayMember = "Name";
                cmbPilot.DataSource = _pilotService.Get<PilotViewModel>().ToList();
            }

            // Verificação de nulidade para o serviço de Aeronaves
            if (_aircraftService != null)
            {
                cmbAircraft.ValueMember = "Id";
                cmbAircraft.DisplayMember = "Model";
                cmbAircraft.DataSource = _aircraftService.Get<AircraftViewModel>().ToList();
            }

            // Verificação de nulidade para o serviço de Aeroportos (Origem)
            if (_airportService != null)
            {
                cmbOriginAirport.ValueMember = "Id";
                cmbOriginAirport.DisplayMember = "Code";
                cmbOriginAirport.DataSource = _airportService.Get<AirportViewModel>().ToList();

                // O mesmo serviço é usado para o Aeroporto de Destino
                cmbDestinyAirport.ValueMember = "Id";
                cmbDestinyAirport.DisplayMember = "Code";
                cmbDestinyAirport.DataSource = _airportService.Get<AirportViewModel>().ToList();
            }
        }

        private void FormToObject(Flight flight)
        {
            flight.Status = cmbStatus.Text;
            //DateTime departTime;
            if (int.TryParse(cmbAircraft.SelectedValue.ToString(), out int aircraftId))
            {
                var aircraft = _aircraftService.GetById<Aircraft>(aircraftId);
                flight.Aircraft = aircraft;
            }
            if (int.TryParse(cmbPilot.SelectedValue.ToString(), out int pilotId))
            {
                var pilot = _pilotService.GetById<Pilot>(pilotId);
                flight.Pilot = pilot;
            }
            if (int.TryParse(cmbOriginAirport.SelectedValue.ToString(), out int originAirportId))
            {
                var originAirport = _airportService.GetById<Airport>(originAirportId);
                flight.OriginAirport = originAirport;
            }
            if (int.TryParse(cmbDestinyAirport.SelectedValue.ToString(), out int destinyAirportId))
            {
                var destinyAirport = _airportService.GetById<Airport>(destinyAirportId);
                flight.DestinyAirport = destinyAirport;
            }
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var flight = _flightService.GetById<Flight>(id);
                    FormToObject(flight);
                    flight = _flightService.Update<Flight, Flight, FlightValidator>(flight);
                }
                else
                {
                    var flight = new Flight();
                    FormToObject(flight);
                    DateTime nextDay = DateTime.Today.AddDays(1);
                    Random random = new Random();
                    int randomHour = random.Next(0, 24);
                    flight.DepartTime = nextDay.AddHours(randomHour);
                    flight = _flightService.Add<Flight, Flight, FlightValidator>(flight);
                }
                MessageBox.Show("Flight saved successfully!", "AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                PopulateGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving flight: {ex.Message}", "AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _flightService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            if (_flightService == null)
            {
                return;
            }

            try
            {
                flights = _flightService.Get<FlightViewModel>().ToList();
                dataGridViewList.DataSource = flights;

                // Ocultar as 4 colunas de ID (Chaves estrangeiras)
                if (dataGridViewList.Columns.Contains("PilotId"))
                {
                    dataGridViewList.Columns["PilotId"]!.Visible = false;
                }
                if (dataGridViewList.Columns.Contains("AircraftId"))
                {
                    dataGridViewList.Columns["AircraftId"]!.Visible = false;
                }
                if (dataGridViewList.Columns.Contains("DepartureAirportId"))
                {
                    dataGridViewList.Columns["DepartureAirportId"]!.Visible = false;
                }
                if (dataGridViewList.Columns.Contains("ArrivalAirportId"))
                {
                    dataGridViewList.Columns["ArrivalAirportId"]!.Visible = false;
                }

                // Renomear colunas para melhor UX (Manter Id, Status, e as 3 de voo)
                if (dataGridViewList.Columns.Contains("Id"))
                {
                    dataGridViewList.Columns["Id"]!.HeaderText = "FlightId";
                }
                if (dataGridViewList.Columns.Contains("Status"))
                {
                    dataGridViewList.Columns["Status"]!.HeaderText = "Status";
                }
                if (dataGridViewList.Columns.Contains("DepartureAirportCode"))
                {
                    dataGridViewList.Columns["DepartureAirportCode"]!.HeaderText = "Origin Airport";
                }
                if (dataGridViewList.Columns.Contains("ArrivalAirportCode"))
                {
                    dataGridViewList.Columns["ArrivalAirportCode"]!.HeaderText = "Destiny Airport";
                }
                if (dataGridViewList.Columns.Contains("DepartTime"))
                {
                    dataGridViewList.Columns["DepartTime"]!.HeaderText = "Depart Time";
                }

                dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao popular a grade de voos: {ex.Message}", @"AeroIF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewList.DataSource = null;
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record?.Cells["Id"].Value.ToString();
            cmbStatus.SelectedValue = record?.Cells["Status"].Value.ToString();

            cmbAircraft.SelectedValue = record?.Cells["AircraftId"].Value;
            cmbPilot.SelectedValue = record?.Cells["PilotId"].Value;

            // CORREÇÃO FINAL: Usando os nomes do ViewModel (Departure/Arrival)
            cmbOriginAirport.SelectedValue = record?.Cells["DepartureAirportId"].Value;
            cmbDestinyAirport.SelectedValue = record?.Cells["ArrivalAirportId"].Value;
        }

        private void FlightForm_Load(object sender, EventArgs e)
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
