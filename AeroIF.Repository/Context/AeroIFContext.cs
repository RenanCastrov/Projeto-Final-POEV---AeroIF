using AeroIF.Domain.Entities;
using AeroIF.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using DBContext = Microsoft.EntityFrameworkCore.DbContext;

namespace AeroIF.Repository.Context
{
    public class AeroIFContext : DBContext
    {
        public AeroIFContext()
        {
            Database.EnsureCreated();
        }
        public AeroIFContext(DbContextOptions<AeroIFContext> op=null) : base(op)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=AeroIF;user=root;password=");
        }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aircraft>(new AircraftMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Pilot>(new PilotMap().Configure);
            modelBuilder.Entity<Flight>(new FlightMap().Configure);
            modelBuilder.Entity<Airport>(new AirportMap().Configure);
            modelBuilder.Entity<City>(new CityMap().Configure);
        }
    }
}
