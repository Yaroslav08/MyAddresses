using MyAddresses.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyAddresses.Application.Interfaces
{
    public interface ICountryService
    {
        Task<Country> GetCountryById(int id);
        Task<List<Country>> GetAllCountries(int skip);
        Task<Country> CreateCountry(Country country);
        Task<Country> EditCountry(Country country);
        Task<Country> RemoveCountry(Country country);
        Task<Country> RestoreCountry(Country country);
    }
}