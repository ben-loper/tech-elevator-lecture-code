
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal
    {        
        public Chicken() : base("Chicken", 3.00M)
        {
            
        }
        
        public override string MakeSoundOnce()
        {
            return "Cluck";
        }
    }
}
