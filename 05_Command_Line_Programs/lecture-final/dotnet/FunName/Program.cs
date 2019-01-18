using System;

namespace FunName
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length >= 3)
            {
                if (args[0] == "add")
                {
                    DisplayAdd(args);
                }
                else if (args[0] == "subtract")
                {
                    DisplaySubract(args);
                }
                else if (args[0] == "multiply")
                {
                    DisplayMultiply(args);
                }
            }
            else
            {
                MainMenu();
            }
        }

        public static void MainMenu()
        {
            bool exit = false;
            while(!exit)
            {
                Console.Clear();
                Console.WriteLine("a) Add");
                Console.WriteLine("s) Subtract");
                Console.WriteLine("m) Multiply");
                Console.WriteLine("q) Quit");

                char input = Console.ReadKey().KeyChar;
                if(input == 'a')
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter numbers to add and make them space delimited.");
                    string numberString = Console.ReadLine();
                    string[] numbers = numberString.Split(' ');
                    DisplayAdd(numbers, false);
                }
                else if (input == 's')
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter numbers to subtract and make them space delimited.");
                    string numberString = Console.ReadLine();
                    string[] numbers = numberString.Split(' ');
                    DisplaySubract(numbers, false);
                }
                else if (input == 'm')
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter numbers to multiply and make them space delimited.");
                    string numberString = Console.ReadLine();
                    string[] numbers = numberString.Split(' ');
                    DisplayMultiply(numbers, false);
                }
                else if (input == 'q')
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please input a valid selection.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        public static void DisplayAdd(string[] args, bool ignore = true)
        {
            int[] values = ConvertNumbers(args, ignore);
            int sum = Add(values);

            Console.WriteLine($"Add: {sum}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void DisplaySubract(string[] args, bool ignore = true)
        {
            int[] values = ConvertNumbers(args, ignore);
            int difference = Subract(values);

            Console.WriteLine($"Subtract: {difference}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void DisplayMultiply(string[] args, bool ignore = true)
        {
            int[] values = ConvertNumbers(args, ignore);
            int product = Multiply(values);

            Console.WriteLine($"Multiply: {product}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static int[] ConvertNumbers(string[] args, bool ignore)
        {
            int startingValue = ignore ? 1 : 0;
            int[] values = new int[ignore ? args.Length - 1 : args.Length];
            for (int i = startingValue; i < args.Length; i++)
            {
                if (ignore)
                {
                    values[i - 1] = int.Parse(args[i]);
                }
                else
                {
                    values[i] = int.Parse(args[i]);
                }
            }
            return values;
        }

        public static int Add(int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }

        public static int Subract(int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            return result;
        }

        public static int Multiply(int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            return result;
        }
    }
}
