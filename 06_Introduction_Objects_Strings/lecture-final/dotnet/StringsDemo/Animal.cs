using System;
using System.Collections.Generic;
using System.Text;

namespace StringsDemo
{
    public class Animal
    {
        public int NumberOfLegs { get; set; }
        public int NumberOfEars { get; set; }
        public string Type { get; set; }
        public string Sound { get; set; }

        public string MakeNoise()
        {
            return Sound;
        }
    }
}
