using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than or equal to 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            string result = "";

            bool isEven = (number % 2 == 0);
            bool isLargerThan100 = (number > 100);
            bool isLargerThanOrEqualTo100 = (number >= 100);
            bool isMultipleOf5 = (number % 5 == 0);

            if(isEven && isLargerThan100 && isMultipleOf5)
            {
                result = "Big Even Number";
            }
            else if(isLargerThanOrEqualTo100)
            {
                result = "Big Number";
            }

            return result;
        }
    }
}
