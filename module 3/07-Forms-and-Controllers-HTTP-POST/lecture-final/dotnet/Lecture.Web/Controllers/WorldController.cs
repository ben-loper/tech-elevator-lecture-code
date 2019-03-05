using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture.Web.DAL;
using Lecture.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lecture.Web.Controllers
{
    public class WorldController : Controller
    {
        private ICountryDAO _countryDao;
        private ICityDAO _cityDao;

        // DI: Step 2 - Add any necessary interfaces as parameters only if needed in this controller
        public WorldController(ICountryDAO countryDao, ICityDAO cityDao)
        {
            _countryDao = countryDao;
            _cityDao = cityDao;
        }

        // Step 1 - Add Index action for intial page load
        [HttpGet]
        public IActionResult Index()
        {
            var countries = _countryDao.GetCountries(); 

            return View(countries);
        }

        [HttpGet]
        public IActionResult AddCity()
        {
            City city = new City();
            return View(city);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCity(City city)
        {
            try
            {
                _cityDao.AddCity(city);
            }
            catch(Exception)
            {
                return View("AddCity");
            }

            CityViewModel vm = new CityViewModel();
            vm.CountryCode = city.CountryCode;
            vm.District = city.District;

            //TempData["CityData"] = vm;

            return RedirectToAction("Confirmation", "World", new { CountryCode = city.CountryCode, District = city.District });
        }

        [HttpGet]
        public IActionResult Confirmation(CityViewModel info)
        {
            //var info = TempData["CityData"];
            return View(info);
        }

        public IActionResult CitiesByCountry(string code)
        {
            var cities = _cityDao.GetCities(code);

            return View(cities);
        }
    }
}