using System;
using System.Collections.Generic;
using System.Linq;

namespace ADOPM3_04_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> FavoriteBands = new Dictionary<string, List<string>>();
            FavoriteBands.Add("ACDC", new List<string>() { "Fly on the Wall", "TnT" });
            FavoriteBands.Add("PinkFloyd", new List<string>() { "Dark side of the moon", "The Wall", "Final Cut" });

            foreach (var performer in FavoriteBands.Keys)
            {
                Console.WriteLine($"\n{performer} albums:");
                foreach (var album in FavoriteBands[performer])
                {
                    Console.WriteLine(album);
                }
            }

            Console.WriteLine(FavoriteBands.ContainsKey("Abba"));
            var myAlbums = FavoriteBands.ToList();
        }
    }

    //Exercise:
    //1.    Use Rectangle from Example6_09 and implement a Dictionary that from a SortedSet<T> extracts the largest Rectangle of each Color. 
    //      Printout the result
}
