using AeroIF.Domain.Base;

namespace AeroIF.Domain.Entities
{
    public class Flight : BaseEntity<int>
    {
        public Flight() 
        {
        }
        public Flight(int id, string status, DateTime departTime, Aircraft aircraft, Pilot pilot, Airport originAirport, Airport destinyAirport) : base(id) 
        {
            Status = status;
            DepartTime = departTime;
            Aircraft = aircraft;
            Pilot = pilot;
            OriginAirport = originAirport;
            DestinyAirport = destinyAirport;
        }
        
        public string Status { get; set; }
        public DateTime DepartTime { get; set; }
        public Aircraft Aircraft { get; set; }
        public Pilot Pilot { get; set; }
        public Airport OriginAirport { get; set; }
        public Airport DestinyAirport { get; set; }

    }
}
