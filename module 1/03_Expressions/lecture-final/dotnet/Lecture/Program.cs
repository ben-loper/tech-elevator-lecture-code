using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 3 and 4 = {Sum(3, 4)}");
            Console.WriteLine($"Sum of 3 and 2 = {Sum(3, 2)}");
            Console.WriteLine($"Sum of 3 and 8 = {Sum(8, 8)}");
            Console.ReadKey();
        }

        public static int Sum(int val1, int val2)
        {
            int result = val1 + val2;
            
            if(val1 == val2)
            {
                string name = $"Result = {result}";
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Else");
            }

            return result;
        }

        public static int Subtract(int val1, int val2)
        {
            int result = val1 - val2;

            return result;
        }
    }
}
