using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class RedDie : Die
    {
        // Constuctors
        public RedDie() : base("Red")
        {
            _sides.Add(1, Brain);
            _sides.Add(2, Feet);
            _sides.Add(3, Feet);
            _sides.Add(4, Blast);
            _sides.Add(5, Blast);
            _sides.Add(6, Blast);
        }

        public override string RollSound()
        {
            return "Kaboom";
        }
    }
   
}
