using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal cat = new Animal();
            //cat.NumberOfLegs = 4;
            //cat.NumberOfEars = 2;
            //cat.Type = "Feline";
            //cat.Sound = "Meow";

            //Animal patches = new Animal();
            //patches.NumberOfEars = cat.NumberOfEars;
            //patches.NumberOfLegs = cat.NumberOfLegs;
            //patches.Type = cat.Type;
            //patches.Sound = cat.Sound;

            //patches.NumberOfEars = 1;

            //Animal parrot = new Animal();
            //parrot.NumberOfLegs = 2;
            //parrot.Type = "Winged Creature";

            //Console.WriteLine($"Cat Sound: {cat.MakeNoise()}");


            string name = "Ada Lovelace";
                        
            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character. ");
            Console.WriteLine($"{name[0]}{name[name.Length-1]}");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            Console.WriteLine("First 3 characters: ");
            for(int i = 0; i < 3; i++)
            {
                Console.Write($"{name[i]}");
            }
            Console.WriteLine();

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("Last 3 characters: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{name[i]}");
            }
            for (int i = name.Length - 3; i < name.Length; i++)
            {
                Console.Write($"{name[i]}");
            }
            Console.WriteLine();

            // 4. What about the last word?
            // Output: Lovelace

            Console.WriteLine("Last Word: ");
            string[] names = name.Split(" ");
            Console.WriteLine(names[names.Length - 1]);
            Console.WriteLine(name.Substring(4));

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\"");
            Console.WriteLine(name.ToLower().Contains("love"));

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            Console.WriteLine("Index of \"lace\": ");
            Console.WriteLine(name.IndexOf("lace"));

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            Console.WriteLine("Number of \"a's\": ");
            int numberAs = name.Split(new char[] { 'a', 'A' }).Length - 1;
            Console.WriteLine(numberAs);
            numberAs = name.ToLower().Split("a").Length - 1;
            Console.WriteLine(numberAs);

            // 8. Replace "Ada Lovelance" with "Ada, Countess of Lovelace"

            Console.WriteLine(name);
            string longName = name.Insert(3, ", Countess of");
            Console.WriteLine(longName);

            // 9. Set name equal to null.
            name = null;

            // 10. If name is equal to null or "", print out "All Done".
            if(name == null || name.Equals(""))
            {
                Console.WriteLine("All Done");
            }            

            Console.ReadLine();
        }
    }
}