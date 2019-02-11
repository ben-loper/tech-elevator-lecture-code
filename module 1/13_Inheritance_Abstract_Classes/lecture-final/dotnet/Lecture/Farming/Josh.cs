using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Josh : Chicken
    {
        public Josh(decimal price) : base(price, true)
        {

        }

        public override string MakeSoundOnce()
        {
            return "Joke";
        }
    }
}
