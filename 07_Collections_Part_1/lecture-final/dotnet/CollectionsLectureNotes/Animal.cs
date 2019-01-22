using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsLectureNotes
{
    public class Animal
    {
        public int NumLegs { get; set; }
        public int NumArms { get; set; }

        public override string ToString()
        {
            return $"Legs: {NumLegs}\nArms: {NumArms}";
        }

        public override bool Equals(object obj)
        {
            return ((Animal)obj).NumLegs == NumLegs;
        }
    }
}
