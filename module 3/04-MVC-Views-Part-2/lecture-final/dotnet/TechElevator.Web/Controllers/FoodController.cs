using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.DAL;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class FoodController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatureBreakfast(string creature)
        {
            // Received request from browers (Step 1 of MVC workflow)

            if (creature == null)
            {
                return NotFound();
            }

            IStarWarsDAL dal = new StarWarsDAL();
            EatDetailViewModel vm = new EatDetailViewModel();
            vm.Creature = creature;
            vm.Meal = "breakfast";

            // Get data from Model (Step 2 & 3 of MVC workflow)
            vm.FoodItems = dal.GetFoodInfo(vm.Creature, vm.Meal);

            // Send data to View (Step 4 & 5 of MVC workflow)
            var htmlResult = View("Eat", vm);

            // Send View data to browser (Step 6 of MVC workflow)
            return htmlResult;
        }


        [HttpGet]
        public IActionResult Eat(EatViewModel eatInfo)
        {
            if (eatInfo.Creature == null || eatInfo.Meal == null)
            {
                return NotFound();
            }

            // Received request from browers (Step 1 of MVC workflow)

            IStarWarsDAL dal = new StarWarsDAL();
            EatDetailViewModel vm = new EatDetailViewModel();
            vm.Creature = eatInfo.Creature;
            vm.Meal = eatInfo.Meal;

            // Get data from Model (Step 2 & 3 of MVC workflow)
            vm.FoodItems = dal.GetFoodInfo(eatInfo.Creature, eatInfo.Meal);

            // Send data to View (Step 4 & 5 of MVC workflow)
            var htmlResult = View(vm);

            // Send View data to browser (Step 6 of MVC workflow)
            return htmlResult;
        }

        //[HttpGet]
        //public IActionResult Eat(EatViewModel eatInfo)
        //{
        //    EatDetailViewModel vm = new EatDetailViewModel();
        //    vm.Creature = eatInfo.Creature;
        //    vm.Meal = eatInfo.Meal;

        //    List<string> test = new List<string>()
        //    {
        //        "banana",
        //        "salmon",
        //        "John"
        //    };
        //    vm.FoodItems = test;

        //    ViewData["EatInfo"] = vm;

        //    return View();
        //}
    }
}