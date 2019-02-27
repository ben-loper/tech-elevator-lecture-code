using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.Web.Models
{
    public class MathTime
    {
        public static int SumMyNums(int[] values)
        {
            int result = 0;
            foreach(var value in values)
            {
                result += value;
            }
            return result;
        }
    }
}
