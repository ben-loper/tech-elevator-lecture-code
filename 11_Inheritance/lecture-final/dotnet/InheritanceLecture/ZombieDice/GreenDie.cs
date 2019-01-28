using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class GreenDie : Die
    {
        // Constuctors
        public GreenDie() : base("Green")
        {
            _sides.Add(1, Brain);
            _sides.Add(2, Brain);
            _sides.Add(3, Brain);
            _sides.Add(4, Feet);
            _sides.Add(5, Feet);
            _sides.Add(6, Blast);
        }

        public override string RollSound()
        {
            return "Squish";
        }
    }
}
