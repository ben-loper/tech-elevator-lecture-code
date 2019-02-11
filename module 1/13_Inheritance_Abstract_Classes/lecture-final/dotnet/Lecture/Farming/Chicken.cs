
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public abstract class Chicken : FarmAnimal
    {
        private const string ChickenStr = "Chicken";

        public bool IsBadAss { get; }

        public Chicken() : base(ChickenStr, 3.00M)
        {
            IsBadAss = false;
        }

        public Chicken(decimal price, bool isBadAss) : base(ChickenStr, price)
        {
            IsBadAss = isBadAss;
        }

        //public override string MakeSoundOnce()
        //{
        //    return "Cluck";
        //}
    }
}
