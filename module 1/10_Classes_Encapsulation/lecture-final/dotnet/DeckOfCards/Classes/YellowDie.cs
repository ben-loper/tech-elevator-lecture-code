using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    public class YellowDie
    {
        private const string Brain = "Brain";
        private const string Feet = "Feet";
        private const string Blast = "Blast";

        // Member Varibles
        private static Dictionary<int, string> _sides = new Dictionary<int, string>()
        {
            {1, Brain },
            {2, Brain },
            {3, Feet },
            {4, Feet },
            {5, Blast },
            {6, Blast }
        };

        private Random _rnd = new Random();

        // Properties
        public string Color { get; set; } = "Yellow";

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

        public static string Probability(int numberOfOccurences, int totalNumberOfSides)
        {
            return (numberOfOccurences / (double)totalNumberOfSides).ToString("N2");
        }
    }
}