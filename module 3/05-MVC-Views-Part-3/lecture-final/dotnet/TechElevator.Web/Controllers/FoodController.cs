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
        // /food (works because default action is Index)
        // /     (works because default controller and action are set to Food and Index)
        // /food/index
        public IActionResult Index()
        {
            List<CreatureViewModel> data = new List<CreatureViewModel>();
            CreatureViewModel creature = new CreatureViewModel();
            creature.Name = "Ewok";
            creature.ImageUrl = "https://img.buzzfeed.com/buzzfeed-static/static/enhanced/web03/2012/5/24/13/enhanced-buzz-28303-1337880144-7.jpg?downsize=700:*&output-format=auto&output-quality=auto";
            creature.ImageSize = "35%";
            data.Add(creature);

            creature = new CreatureViewModel();
            creature.Name = "Wookie";
            creature.ImageUrl = "https://contattafiles.s3.us-west-1.amazonaws.com/tecommunity/6oNYJw54EECOLse/Pasted%20Image%3A%20Mar%201%2C%202019%20-%2011%3A15%3A09am";
            creature.ImageSize = "70%";
            data.Add(creature);

            creature = new CreatureViewModel();
            creature.Name = "Jawa";
            creature.ImageUrl = "https://i.imgur.com/sT9bTkIl.jpg";
            creature.ImageSize = "100%";
            data.Add(creature);

            return View(data);
        }

        [HttpGet]
        //[Route("food/breakfast")]
        // /food/creaturebreakfast
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
        // /food/eat?creature=wookie&meal=breakfast
        // /food/eat/wookie/breakfast
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