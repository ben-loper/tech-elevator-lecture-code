using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] values = { 1, 2, 3 };
            //double average = Avg(values);
            //Console.WriteLine($"Avg: {average}");
            //Console.ReadKey();

            /////////////////////////
            //1. Ask for a first name
            /////////////////////////
            Console.WriteLine("Please provide your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("You entered " + firstName);

            /////////////////////////
            //2. Ask for a first and last name
            /////////////////////////
            Console.WriteLine("Please provide another first name");
            string secondName = Console.ReadLine();

            Console.WriteLine("How about a last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hi {secondName} {lastName}!");

            Console.WriteLine("Where do you live?");
            string city = Console.ReadLine();

            /////////////////////////
            //3. Read in and print a message out how many times?
            /////////////////////////
            Console.WriteLine("What message do you want me to print out?");
            string message = Console.ReadLine();

            Console.WriteLine("Ok, how many times?");
            //int numberOfTimes = Console.ReadLine(); //<-- results in a compile error, why??

            string input = Console.ReadLine();
            //try
            //{
            int numberOfTimesValue = int.Parse(input);
            for (int i = 0; i < numberOfTimesValue; i++)
            {
                Console.WriteLine(message);
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            /////////////////////////
            //4. Read in a convert the value answer to a boolean
            /////////////////////////
            Console.WriteLine("Was there bad traffic today? Enter TRUE/FALSE");
            input = Console.ReadLine();
            bool trafficValue = bool.Parse(input);

            if (trafficValue)
            {
                Console.WriteLine($"No surprise, its {city}!");
            }
            else
            {
                Console.WriteLine("Maybe everyone stayed home");
            }

            /////////////////////////
            //5. Read in and convert the answer to a decimal
            /////////////////////////
            Console.WriteLine("How many hours do you sleep per night on average?");
            input = Console.ReadLine();
            double sleepValue = double.Parse(input);

            Console.WriteLine($"You said you only slept {sleepValue}");

            Console.ReadKey();
        }

        public static double Avg(int[] values)
        {
            double result = 0;

            int sumValues = Sum(values);
            result = (double)sumValues / values.Length;

            return result;
        }

        public static int Sum(int[] values)
        {
            int result = 0;

            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }

            return result;
        }
    }
}
