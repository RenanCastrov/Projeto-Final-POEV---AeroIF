using AeroIF.App.Other;
using AeroIF.App.Register;
using AeroIF.App.ViewModel;
using AeroIF.Domain.Base;
using AeroIF.Domain.Entities;
using AeroIF.Repository.Context;
using AeroIF.Repository.Repository;
using AeroIF.Service.Service;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace AeroIF.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        public static object? ServicesProvider { get; internal set; }

        public static void ConfigureServices() 
        {
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<AeroIFContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
             );

            #region Repositories
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Pilot>, BaseRepository<Pilot>>();
            services.AddScoped<IBaseRepository<Aircraft>, BaseRepository<Aircraft>>();
            services.AddScoped<IBaseRepository<Flight>, BaseRepository<Flight>>();
            services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
            services.AddScoped<IBaseRepository<Airport>, BaseRepository<Airport>>();
            #endregion

            #region Services
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Pilot>, BaseService<Pilot>>();
            services.AddScoped<IBaseService<Aircraft>, BaseService<Aircraft>>();
            services.AddScoped<IBaseService<Flight>, BaseService<Flight>>();
            services.AddScoped<IBaseService<City>, BaseService<City>>();
            services.AddScoped<IBaseService<Airport>, BaseService<Airport>>();
            #endregion

            #region Forms

            services.AddScoped<UserForm, UserForm>();

            services.AddTransient<UserForm>();
            services.AddTransient<PilotForm>();
            services.AddTransient<AircraftForm>();
            services.AddTransient<FlightForm>();
            services.AddTransient<CityForm>();
            services.AddTransient<AirportForm>();
            services.AddTransient<Login>();
            services.AddTransient<MainForm>(sp =>
                new MainForm(
                        sp.GetRequiredService<IBaseService<User>>(),
                        sp
                    )
            );
            #endregion

            services.AddSingleton(
                    new MapperConfiguration(
                        config => {
                            config.CreateMap<User, UserViewModel>();
                            config.CreateMap<Pilot, PilotViewModel>();
                            config.CreateMap<Aircraft, AircraftViewModel>();
                            config.CreateMap<City, CityViewModel>();
                            config.CreateMap<Airport, AirportViewModel>()
                                .ForMember(dest => dest.City, dest => dest.MapFrom(src => $"{src.City.Name}/{src.City.State}"))
                                .ForMember(dest => dest.CityId, dest => dest.MapFrom(src => src.City.Id));
                            config.CreateMap<Flight, FlightViewModel>()
                                .ForMember(dest => dest.ArrivalAirportCode, dest => dest.MapFrom(src => src.DestinyAirport.Code))
                                .ForMember(dest => dest.ArrivalAirportId, dest => dest.MapFrom(src => src.DestinyAirport.Id))
                                .ForMember(dest => dest.DepartureAirportCode, dest => dest.MapFrom(src => src.OriginAirport.Code))
                                .ForMember(dest => dest.DepartureAirportId, dest => dest.MapFrom(src => src.OriginAirport.Id))
                                .ForMember(dest => dest.PilotId, dest => dest.MapFrom(src => src.Pilot.Id))
                                .ForMember(dest => dest.AircraftId, dest => dest.MapFrom(src => src.Aircraft.Id));
                        },
                        NullLoggerFactory.Instance).CreateMapper()
                );
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
