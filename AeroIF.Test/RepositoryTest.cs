using AeroIF.Domain.Entities;
using AeroIF.Repository.Context;
using AeroIF.Repository.Repository;
using System.Text.Json;

namespace AeroIF.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        /*
        [TestMethod]
        public void TestAircraft()
        {
            using (var context = new AeroIFContext())
            {
                Console.WriteLine("Connected!");

                var aircraft1 = new Aircraft {Model= "Boeing 487", Company= "Onodela Airways",Capacity= 150 };
                var aircraft2 = new Aircraft {Model= "Chulapa", Company= "VoeValtebas", Capacity= 100 };
                var aircraft3 = new Aircraft {Model= "Manivela 123", Company= "BelezaJovem", Capacity= 150 };

                context.Aircrafts.Add(aircraft1);
                context.Aircrafts.Add(aircraft2);
                context.Aircrafts.Add(aircraft3);

                context.SaveChanges();
                Console.WriteLine("Aircrafts added!");

            }
            using (var context = new AeroIFContext())
            {
                foreach (var aircraft in context.Aircrafts)
                {
                    Console.WriteLine(JsonSerializer.Serialize(aircraft));
                }
                Console.WriteLine("Aircrafts listed!");
            }
        }*/
        [TestMethod]
        public void TestPilot() 
        {
            var context = new AeroIFContext();
            var _pilotRepository = new BaseRepository<Pilot>(context);

            var pilot1 = new Pilot();
            pilot1.Name = "Flavio Grigas";
            pilot1.License = "ABC12345";
            _pilotRepository.Insert(pilot1);

            var _pilot2 = new Pilot();
            _pilot2.Name = "Breno José";
            _pilot2.License = "XYZ67890";
            _pilotRepository.Insert(_pilot2);
        }
    }
}
