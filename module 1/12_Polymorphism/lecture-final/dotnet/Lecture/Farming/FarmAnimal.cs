using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class FarmAnimal : ISingable, ISellable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public FarmAnimal(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual string MakeSoundOnce()
        {
            return "";
        }

        public string MakeSoundTwice()
        {
            return MakeSoundOnce() + " " + MakeSoundOnce();
        }
    }
}
