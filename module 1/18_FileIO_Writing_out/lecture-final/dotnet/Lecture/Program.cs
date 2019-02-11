using System;
using Lecture.Aids;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here are a few examples of reading in a file and writing out values
            // to demonstrate their value.
            //ReadingInFiles.ReadACharacterFile();
            //ReadingCSVFiles.ReadFile();  
            //WritingTextFiles.WritingAFile();
            BinaryFileWriter.WritePrimitiveValues(); 
            //BinaryFileWriter.ReadPrimitiveValues();
            //BinaryImageManipulator.ReadFileIn();
            //PerformanceDemo.SlowPerformance();
            //PerformanceDemo.FastPerformance();

            //Start: This section is super cool!
<<<<<<< HEAD:18_FileIO_Writing_out/lecture-final/dotnet/Lecture/Program.cs
            Serialization.SerializingXMLData();
=======
            //Serialization.SerializingXMLData();
>>>>>>> 2ea2308d8eaff121197b96212e033a98d8f5ffa7:module 1/18_FileIO_Writing_out/lecture-final/dotnet/Lecture/Program.cs
            //Serialization.SerializingBinaryData();
            //End: This section is super cool!

            // Students find value in building something useful. 
            // As a group you could build something that prompts the user for data and saves it to a file.
            // OR reads a file in and "processes" the data (geocoding?)

            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
