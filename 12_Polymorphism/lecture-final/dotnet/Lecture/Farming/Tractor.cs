using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; set; } = "Tractor";

        public string MakeSoundOnce()
        {
            return "Vroom";
        }

        public string MakeSoundTwice()
        {
            return MakeSoundOnce() + " " + MakeSoundOnce();
        }
    }
}
