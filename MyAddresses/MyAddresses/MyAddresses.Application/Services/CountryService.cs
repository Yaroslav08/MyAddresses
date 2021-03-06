using MyAddresses.Application.Interfaces;
using MyAddresses.Domain.Interfaces;
using MyAddresses.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Application.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRep;
        public CountryService(ICountryRepository countryRep)
        {
            _countryRep = countryRep;
        }

        public async Task<Country> CreateCountry(Country country)
        {
            return await _countryRep.CreateAsync(country);
        }

        public async Task<Country> EditCountry(Country country)
        {
            return await _countryRep.UpdateAsync(country);
        }

        public async Task<List<Country>> GetAllCountries(int skip)
        {
            return await _countryRep.GetAllAsync(skip);
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await _countryRep.GetByWhereAsync(d => d.Id == id);
        }

        public async Task<Country> RemoveCountry(Country country)
        {
            return await _countryRep.RemoveAsync(country);
        }

        public async Task<Country> RestoreCountry(Country country)
        {
            return await _countryRep.CreateAsync(country);
        }
    }
}