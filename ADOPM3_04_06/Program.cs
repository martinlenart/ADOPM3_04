using System;
using System.Text;

namespace ADOPM3_04_06
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder[] builders = new StringBuilder[5];
            builders[0] = new StringBuilder("builder0");
            builders[1] = new StringBuilder("builder1");
            builders[2] = new StringBuilder("builder2");

            StringBuilder[] builders2 = builders; // Copy of the reference, One array
            builders[2].Append("...added to builders");
            Console.WriteLine(builders2[2]); // builder2...added to builders

            StringBuilder[] shallowClone = (StringBuilder[])builders.Clone();
            builders[2].Append("...change again to builders");
            Console.WriteLine(shallowClone[2]); // builder2...added to builders...change again to builders

            //Convert array to lengths using Lambda Expression delegate
            int?[] builder_lengths = Array.ConvertAll<StringBuilder, int?>(builders2, sb => sb?.Length);
            foreach (int? i in builder_lengths)
                Console.WriteLine(i); //8, 8, 55
         }
    }

    //Exercises:
    //1.    Make a deep Clone of array "builders". Make a textual change to all elements in array "builders" using Lambda Expressions.
    //      Printout and confirm that the deep clone is unchanged
    //2.    Make a deep Clone of array "builders" using Lambda Expressions
}
