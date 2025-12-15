using AutoMapper;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Repository.Context;
using AeroIF.Repository.Repository;
using AeroIF.Service.Service;
using AeroIF.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace AeroIF.Test;

[TestClass]
public class ServiceTest
{
    private ServiceCollection? services;
    public ServiceProvider ConfigureServices()
    {
        services = new ServiceCollection();
        services.AddDbContext<AeroIFContext>();
        services.AddScoped<IBaseRepository<Flight>, BaseRepository<Flight>>();
        services.AddScoped<IBaseService<Flight>, BaseService<Flight>>();
        services.AddSingleton(
            new MapperConfiguration(
                config => { config.CreateMap<Flight, Flight>(); }, NullLoggerFactory.Instance).CreateMapper()
            );
        return services.BuildServiceProvider();
    }
    [TestMethod]
    public void TestFlightService()
    {
        var serviceProvider = ConfigureServices();
        var flightService = serviceProvider.GetService<IBaseService<Flight>>();
        var flight = new Flight
        {
            Status = "On Time",
            DepartTime = DateTime.Now.AddHours(2),
            Aircraft = new Aircraft
            {
                Model = "Boeing 737",
                Company = "AeroIF Airlines",
                Capacity = 180
            },
            Pilot = new Pilot
            {
                Name = "John Cena",
                License = "XYZ12345"
            },
            OriginAirport = new Airport
            {
                Name = "JFK International Airport",
                Code = "JFK",
                City = new City
                {
                    Name = "New York",
                    State = "NY",
                    Country = "United States"
                }
            },
            DestinyAirport = new Airport
            {
                Name = "Los Angeles International Airport",
                Code = "LAX",
                City = new City
                {
                    Name = "Los Angeles",
                    State = "CA",
                    Country = "United States"
                }
            }
        };
        var addedFlight = flightService!.Add<Flight, Flight, FlightValidator>(flight);
        Console.WriteLine("Added Flight: " + JsonSerializer.Serialize(addedFlight));
        var fetchedFlight = flightService.GetById<Flight>(addedFlight.Id);
        Console.WriteLine("Fetched Flight: " + JsonSerializer.Serialize(fetchedFlight));
    }
}
