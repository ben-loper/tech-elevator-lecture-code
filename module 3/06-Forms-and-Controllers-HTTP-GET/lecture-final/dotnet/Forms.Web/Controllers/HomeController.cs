using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forms.Web.Models;
using Forms.Web.DAL;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Forms.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICityDAL cityDAL;

        public HomeController(ICityDAL cityDAL)
        {
            this.cityDAL = cityDAL;
        }

        /// <summary>
        /// Represents an index action.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Represents a search action.
        /// </summary>
        /// <returns></returns>
        public IActionResult Search()
        {
            CitySearchModel model = new CitySearchModel();
            var countries = cityDAL.GetCountries();
            foreach(var country in countries)
            {
                model.Countries.Add(new SelectListItem(country.Name, country.Code));
            }

            // Display a search page
            return View(model);
        }
        
        /// <summary>
        /// Represents a search result.
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public IActionResult Results(CitySearchModel searchModel)
        {
            var cities = cityDAL.GetCities(searchModel.CountryCode, searchModel.District);

            // Update the search model with the cities returned
            searchModel.Results = cities;

            // Display search results
            return View(searchModel);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
