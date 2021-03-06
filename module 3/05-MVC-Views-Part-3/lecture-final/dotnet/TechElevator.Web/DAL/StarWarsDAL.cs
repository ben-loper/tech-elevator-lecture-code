﻿using TechElevator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.Web.DAL
{
    public class StarWarsDAL : IStarWarsDAL
    {
        // Mock Data
        private List<Film> films = new List<Film>()
        {
            new Film() { Id = "solo", Name = "Solo: A Star Wars Story", Length = 185, YearReleased = 2018, ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/solo-theatrical-poster-1000_27861ab7.jpeg?region=0%2C279%2C1000%2C503&width=768"},
            new Film() { Id = "swviii", Name = "Star Wars Episode VIII: The Last Jedi", Length = 195, YearReleased = 2017, ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/the-last-jedi-theatrical-poster-tall-a_6a776211.jpeg?region=0%2C53%2C1536%2C768&width=768"},
            new Film() { Id = "rogue-one", Name = "Rogue One: A Star Wars Story", Length = 179, YearReleased = 2016, ImageUrl = "https://lumiere-a.akamaihd.net/v1/images/rogueone_onesheeta_8a255456.jpeg?region=0%2C77%2C1688%2C849&width=768"},
            new Film() { Id = "swix", Name = "Star Wars Episode IX", Length = 200, YearReleased = 2019 }
        };

        /// <summary>
        /// Returns all of the films.
        /// </summary>
        /// <returns></returns>
        public IList<Film> GetFilms()
        {
            return films;
        }

        /// <summary>
        /// Returns a single film
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Film GetFilm(string id)
        {
            return films.FirstOrDefault(film => film.Id.ToLower() == id.ToLower());
        }

        public List<string> GetFoodInfo(string creature, string meal)
        {
            List<string> result = new List<string>();

            if(creature.ToLower() == "wookie")
            {
                if(meal.ToLower() == "breakfast")
                {
                    result.Add("eggs");
                    result.Add("bacon");
                    result.Add("orange juice");
                }
                else if (meal.ToLower() == "lunch")
                {
                    result.Add("babies");
                    result.Add("bacon");
                    result.Add("v8");
                }
                else if (meal.ToLower() == "dinner")
                {
                    result.Add("unlucky adventurer");
                    result.Add("ale");
                }
            }
            else if (creature.ToLower() == "jawa")
            {
                if (meal.ToLower() == "breakfast")
                {
                    result.Add("bolts");
                    result.Add("glue");
                    result.Add("blinker fluid");
                }
                else if (meal.ToLower() == "lunch")
                {
                    result.Add("tide pods");
                    result.Add("meth");
                    result.Add("blood");
                }
                else if (meal.ToLower() == "dinner")
                {
                    result.Add("sand");
                }
            }
            else if (creature.ToLower() == "ewok")
            {
                if (meal.ToLower() == "breakfast")
                {
                    result.Add("leaves");
                    result.Add("storm troopers");
                    result.Add("spring water");
                }
                else if (meal.ToLower() == "lunch")
                {
                    result.Add("crank");
                    result.Add("sugar water");
                }
                else if (meal.ToLower() == "dinner")
                {
                    result.Add("AT Walker");
                }
            }

            return result;
        }
    }
}
