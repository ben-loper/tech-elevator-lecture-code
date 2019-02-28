using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.Web.Models
{
    public class EatDetailViewModel
    {
        public string Creature { get; set; }
        public string Meal { get; set; }
        public List<string> FoodItems { get; set; }
    }
}
