using MyAddresses.Domain.Interfaces;
using MyAddresses.Domain.Models;
namespace MyAddresses.Infrastructure.Data.Repositories
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {

    }
}