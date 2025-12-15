using AeroIF.Domain.Base;

namespace AeroIF.Domain.Entities
{
    public class City : BaseEntity<int>
    {
        public City() 
        {

        }
        public City(int id, string name, string state, string country) : base(id)
        {
            Name = name;
            Country = country;
            State = state;
        }
        public string Name { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }
}
