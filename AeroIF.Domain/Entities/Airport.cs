using AeroIF.Domain.Base;

namespace AeroIF.Domain.Entities
{
    public class Airport : BaseEntity<int>
    {
        public Airport() 
        {

        }
        public Airport(int id, string name, string code, City city) : base(id)
        {
            Name = name;
            Code = code;
            City = city;
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public City City { get; set; }
    }
}
