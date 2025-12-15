using AeroIF.Domain.Base;

namespace AeroIF.Domain.Entities
{
    public class Aircraft : BaseEntity<int>
    {
        public Aircraft() 
        {

        }
        public Aircraft(int id, string model, string company, int capacity) : base(id)
        {
            Model = model;
            Company = company;
            Capacity = capacity;
        }

        public string Model { get; set; }
        public string Company { get; set; }
        public int Capacity { get; set; }
    }
}
