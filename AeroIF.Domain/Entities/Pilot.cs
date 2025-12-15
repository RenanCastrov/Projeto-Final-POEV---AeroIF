using AeroIF.Domain.Base;

namespace AeroIF.Domain.Entities
{
    public class Pilot : BaseEntity<int>
    {
        public Pilot() 
        {

        }
        public Pilot(int id, string name, string license) : base(id)
        {
            Name = name;
            License = license;
        }

        public string Name { get; set; }
        public string License { get; set; }
    }
}
