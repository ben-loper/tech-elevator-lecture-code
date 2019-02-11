using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class Die
    {
        // Member Variables
        public const string Brain = "Brain";
        public const string Feet = "Feet";
        public const string Blast = "Blast";

        protected Dictionary<int, string> _sides = new Dictionary<int, string>();
        private Random _rnd = new Random();

        // Properties
        public string Color { get; set; }
        
        // Constructors
        public Die(string color)
        {
            Color = color;
        }

        // Methods
        public string Roll()
        {
            // Return a random side value
            int sideKey = _rnd.Next(1, 7);

            return _sides[sideKey];
        }

        public virtual string RollSound()
        {
            return "Meh";
        }
    }
}
