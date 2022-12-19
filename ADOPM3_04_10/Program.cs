using System;
using System.Collections.Generic;
using System.Linq;

namespace ADOPM3_04_10
{
    class Program
    {
        class Car
        {
            public int Year { get; set; }
            public string Make { get; set; }
        }
        static void Main(string[] args)
        {
            /*
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("HelloGer", "Guten Morgen");
            dic.Add("HelloEng", "Good morgning");
            dic["HelloGer"] = "Guten Tag";

            Console.WriteLine(dic["HelloGer"]);
            Console.WriteLine(dic["HelloEng"]);

            Dictionary<string, Car> dic2= new Dictionary<string, Car>();
            dic2.Add("NMN854", new Car { Year = 2022, Make = "Volvo" });
            dic2.Add("YMY789", new Car { Year = 2019, Make = "Suzuki" });
            
            Console.WriteLine(dic2["NMN854"].Make);

            Console.WriteLine("HelloGer".GetHashCode());
            Console.WriteLine("HelloGeR".GetHashCode());

            Console.WriteLine((new Car { Year = 2019, Make = "Suzuki" }).GetHashCode());
            */


            Dictionary<string, List<string>> FavoriteBands = new Dictionary<string, List<string>>();

            FavoriteBands.Add("ACDC", new List<string>() { "Fly on the Wall", "TnT", "For those about to Rock" });
            FavoriteBands.Add("PinkFloyd", new List<string>() { "Dark side of the moon", "The Wall", "Final Cut" });
            FavoriteBands.Add("Bob Dylan", new List<string>() { "Infidels" });

            var l = FavoriteBands["ACDC"];
            l.ForEach(item => Console.WriteLine(item));



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
