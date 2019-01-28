using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class YellowDie : Die
    {
        // Constuctors
        public YellowDie() : base("Yellow")
        {
            _sides.Add(1, Brain);
            _sides.Add(2, Brain);
            _sides.Add(3, Feet);
            _sides.Add(4, Feet);
            _sides.Add(5, Blast);
            _sides.Add(6, Blast);
        }

        public override string RollSound()
        {
            return "Plod PLod";
        }

    }
}