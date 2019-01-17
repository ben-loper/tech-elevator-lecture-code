using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureProblem
    {
        /*
         10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            // create variable that holds the highest value
            int maxValue;

            // initialize our variable to the first position in the array
            maxValue = randomNumbers[0];

            // loop through every element in the array starting at position 2
            for (int i = 1; i < randomNumbers.Length; i++)
            {
                // check to see if current position is greater than our variable
                if (randomNumbers[i] > maxValue)
                {
                    // if true then set variable to current position value
                    maxValue = randomNumbers[i];
                }
            }

            // return variable
            return maxValue;
        }
    }
}
