using Microsoft.AspNetCore.Mvc;
using MyAddresses.Application.Interfaces;
using MyAddresses.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAddresses.MVC.Controllers
{
    [Route("country")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await _countryService.GetAllCountries(0);
            return View(countries);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountryById(int id)
        {
            var country = await _countryService.GetCountryById(id);
            return View(country);
        }


        [HttpGet("create")]
        public IActionResult CreateCountry()
        {
            return View(new Country
            {
                Id = 0,
                CreatedAt = DateTime.UtcNow
            });
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCountry(Country country)
        {
            var countryCreated = await _countryService.CreateCountry(country);
            return LocalRedirect($"~/country/{countryCreated.Id}");
        }


        [HttpGet("edit")]
        public async Task<IActionResult> EditCountry(int id)
        {
            var country = await _countryService.GetCountryById(id);
            return View(country);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> EditCountry(Country country)
        {
            var countryCreated = await _countryService.EditCountry(country);
            return View("GetCountryById", countryCreated);
        }
    }
}
