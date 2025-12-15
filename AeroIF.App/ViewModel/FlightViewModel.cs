namespace AeroIF.App.ViewModel
{
    public class FlightViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int PilotId { get; set; }
        public int AircraftId { get; set; }
        public int DepartureAirportId { get; set; } // ID de Origem (Partida)
        public string DepartureAirportCode { get; set; }
        public int ArrivalAirportId { get; set; } // ID de Destino (Chegada)
        public string ArrivalAirportCode { get; set; }
        public DateTime DepartTime { get; set; }

    }
}
