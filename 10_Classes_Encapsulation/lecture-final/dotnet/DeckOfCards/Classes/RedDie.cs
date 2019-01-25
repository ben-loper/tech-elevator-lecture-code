using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    public class RedDie
    {
        private const string Brain = "Brain";
        private const string Feet = "Feet";
        private const string Blast = "Blast";

        // Member Varibles
        private static Dictionary<int, string> _sides = new Dictionary<int, string>()
        {
            {1, Brain },
            {2, Feet },
            {3, Feet },
            {4, Blast },
            {5, Blast },
            {6, Blast }
        };

        private Random _rnd = new Random();

        // Properties
        public string Color { get; set; } = "Red";

        public static string LastSideRolled { get; private set; }

        // Constuctors

        // Methods
        public string Roll()
        {
            // Return a random side value
            int sideKey = _rnd.Next(1, 7);

            LastSideRolled = _sides[sideKey];

            return LastSideRolled;
        }
    }
   
}
