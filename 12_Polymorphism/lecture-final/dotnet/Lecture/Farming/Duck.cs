using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Duck : FarmAnimal
    {
        public Duck() : base("Duck", 5.00M)
        {
            
        }

        public override string MakeSoundOnce()
        {
            return "Quack";
        }
    }
}
