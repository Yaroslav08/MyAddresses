using Microsoft.Extensions.DependencyInjection;
using MyAddresses.Application.Interfaces;
using MyAddresses.Application.Services;
using MyAddresses.Domain.Interfaces;
using MyAddresses.Infrastructure.Data;
using MyAddresses.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IAreaRepository, AreaRepository>();


            services.AddScoped<IBindingRepository, BindingRepository>();


            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICountryService, CountryService>();

            services.AddScoped<IFlatRepository, FlatRepository>();


            services.AddScoped<IRegionRepository, RegionRepository>();


            services.AddScoped<ISettlementRepository, SettlementRepository>();


            services.AddScoped<IStreetRepository, StreetRepository>();

        }
    }
}