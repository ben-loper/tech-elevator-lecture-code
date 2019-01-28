using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class ExpansionDie : GreenDie
    {
        public override string RollSound()
        {
            return base.RollSound() + " - I expand thee green die.";
        }
    }
}
