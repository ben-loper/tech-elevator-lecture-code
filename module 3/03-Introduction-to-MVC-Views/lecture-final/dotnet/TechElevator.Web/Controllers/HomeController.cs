using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Greeting()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PuddingTime(UserViewModel data)
        {
            // UserViewModel is bound based on the property names to url parameters
            
            // A way (not a good one) to pass data from controller to view
            //ViewData["Data"] = data;
            
            return View(data);
        }

        [HttpGet]
        public IActionResult AddTwoNumbers(int[] numbers)
        {
            return View("SumNumbers", MathTime.SumMyNums(numbers));
        }
    }
}