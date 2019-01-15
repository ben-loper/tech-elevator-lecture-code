using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */

            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */

            byte seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */

            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */

            double bigPi = 3.1454;
            float littlePi = (float)bigPi;
            Console.WriteLine(littlePi);

            /*
            7. Create and set a variable that holds your name.
            */

            string myName = "Mike";

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            byte numButtons = 6;

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */

            const float batteryLife = 83.6F;

            //const double PI = 3.14;
            //int circleRadius = 2;
            //float areaOfCircle = (float)(PI + circleRadius * circleRadius);

            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */

            int difference = 121 - 27;

            //int whole = 20 / 3;
            //int remainder = 20 % 3;
            //float decimalNum = 20F / 3F;

            //Console.WriteLine($"Whole: {whole} Remainder: {remainder} Decimal: {decimalNum}");

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */

            double sum = 12.3 + 32.1;

            /*
            12. Create a string that holds your full name.
            */

            string fullName = "Thomas Martinez";
            Console.WriteLine($"Fullname: {fullName}");

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */

            string greeting = "Hello, " + fullName;
            Console.WriteLine($"Greeting: {greeting}");

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */

            fullName = fullName + " Esquire";
            Console.WriteLine($"Esquire: {fullName}");

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */

            fullName += " Esquire";
            Console.WriteLine($"+=: {fullName}");

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */

            string sawMovieVerion = "Saw";
            sawMovieVerion += 2;
            Console.WriteLine($"Saw2: {sawMovieVerion}");

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            sawMovieVerion += 0;
            Console.WriteLine($"Saw20: {sawMovieVerion}");

            /*
            18. What is 4.4 divided by 2.2?
            */

            Console.WriteLine(4.4/2.2);

            /*
            19. What is 5.4 divided by 2?
            */

            Console.WriteLine(4.4 / 2);

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */

            Console.WriteLine(5F/2F);

            /*
            21. What is 5.0 divided by 2?
            */

            Console.WriteLine(5.0/2);

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */

            decimal bankBalance = 1234.56M;

            /*
            23. If I divide 5 by 2, what's my remainder?
            */

            Console.WriteLine(5%2);

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */

            byte val1 = 3;
            int val2 = 1000000000;
            long result = val1 * (long)val2;
            Console.WriteLine(result);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */

            bool doneWithExercises = false;

            /*
            26. Now set doneWithExercise to true.
            */

            doneWithExercises = true;

            Console.ReadLine();
        }
    }
}
