using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            List<FarmAnimal> livestock = new List<FarmAnimal>();
            List<ISingable> singingThings = new List<ISingable>();
            List<ISellable> forSale = new List<ISellable>();

            var cow = new Cow();
            var duck = new Duck();
            var chicken = new Josh(4.00M);
            var tractor = new Tractor();
            var apple = new Apple();

            livestock.Add(cow);
            forSale.Add(cow);
            singingThings.Add(cow);

            livestock.Add(duck);
            forSale.Add(duck);
            singingThings.Add(duck);

            livestock.Add(chicken);
            forSale.Add(chicken);
            singingThings.Add(chicken);

            singingThings.Add(tractor);

            forSale.Add(apple);

            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            foreach(FarmAnimal animal in livestock)
            {                
                Console.WriteLine("And on his farm there was a " + animal.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + animal.MakeSoundTwice() + " here and a " + animal.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + animal.MakeSoundOnce() + ", there a " + animal.MakeSoundOnce() + " everywhere a " + animal.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();

                //Cow cow = animal as Cow;
                //if (animal != null)
                //{
                //    Console.WriteLine(cow.Graze());
                //    Console.WriteLine();
                //}
            }

            // ------ NOW
            // What if we wanted to sing about other things on the farm?
            // Can it be done? 
            Console.WriteLine();
            foreach (ISingable singer in singingThings)
            {
                Console.WriteLine("And on his farm there was a " + singer.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + singer.MakeSoundTwice() + " here and a " + singer.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + singer.MakeSoundOnce() + ", there a " + singer.MakeSoundOnce() + " everywhere a " + singer.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }

            Console.WriteLine();
            foreach (ISellable item in forSale)
            {
                Console.WriteLine($"Price: {item.Price.ToString("C")}");
            }
            Console.ReadLine();
        }
    }
}