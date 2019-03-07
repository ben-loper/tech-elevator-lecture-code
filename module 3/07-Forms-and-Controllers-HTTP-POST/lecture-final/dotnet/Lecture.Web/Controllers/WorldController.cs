using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture.Web.DAL;
using Lecture.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionControllerData;

namespace Lecture.Web.Controllers
{
    public class WorldController : SessionController
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

        // Step 3 - Add AddCity get action for add city input controls
        [HttpGet]
        public IActionResult AddCity()
        {
            City city = new City();
            return View(city);
        }

        // Step 5 - Add AddCity post action for add city submit from Form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCity(City city)
        {
            IActionResult result = null;

            // Are there errors
            if (!ModelState.IsValid)
            {
                // Return the new view again
                result = View("AddCity");
            }
            else
            {
                try
                {
                    // Step 6 - Save new city information to database
                    _cityDao.AddCity(city);

                    CityViewModel vm = new CityViewModel();
                    vm.CountryCode = city.CountryCode;
                    vm.District = city.District;

                    SetTempData("CityData", vm);

                    // Step 7 - Redirect the browser to the world/confirmation action to prevent re-submition
                    result = RedirectToAction("Confirmation", "World"/*, new { CountryCode = city.CountryCode, District = city.District }*/);
                }
                catch (Exception)
                {
                    // If we failed to add the city to the DAO then return to the form page
                    result = View("AddCity");
                }
            }

            return result;
        }

        [HttpGet]
        public IActionResult Confirmation(/*CityViewModel info*/)
        {
            var info = GetTempData<CityViewModel>("CityData");
            return View(info);
        }

        public IActionResult CitiesByCountry(string code)
        {
            var cities = _cityDao.GetCities(code);

            return View(cities);
        }
    }
}