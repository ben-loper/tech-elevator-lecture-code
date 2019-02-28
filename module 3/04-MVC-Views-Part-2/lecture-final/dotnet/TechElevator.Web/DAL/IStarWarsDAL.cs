using TechElevator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.Web.DAL
{
    public interface IStarWarsDAL
    {
        /// <summary>
        /// Returns all of the films.
        /// </summary>
        /// <returns></returns>
        IList<Film> GetFilms();

        /// <summary>
        /// Returns a single film
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Film GetFilm(string id);

        /// <summary>
        /// Gets the food a Star Wars creature would eat for a given meal
        /// </summary>
        /// <param name="creature">The creature in question (Wookie, Jawa, Ewok)</param>
        /// <param name="meal">The meal to be eaten (Breakfast, Lunch, Dinner)</param>
        /// <returns>List of food items consumed at meal</returns>
        List<string> GetFoodInfo(string creature, string meal);
    }
}
