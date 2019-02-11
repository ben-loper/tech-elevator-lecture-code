using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Cow : FarmAnimal
    {
        public Cow() : base("Cow", 5000.00M)
        {
            
        }

        public override string MakeSoundOnce()
        {
            return "Moo";
        }

        public string Graze()
        {
            return "Hey I love to eat grass because I'm a COW!!!!";
        }

    }
}
