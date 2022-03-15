﻿using System;
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

            /*
        Dictionary<string, string> openWith = new Dictionary<string, string>()
            {{ "txt", "notepad.exe" },
             { "bmp", "paint.exe" },
             { "dib", "paint.exe" },
             { "rtf", "wordpad.exe" }};

        foreach (var e in openWith) Console.WriteLine($"Key: {e.Key} Value: {e.Value}"); // ...Key: rtf Value: wordpad.exe

        //openWith.Add("rtf", "wordpad.exe"); // Exception
        Console.WriteLine(openWith["rtf"]);
        openWith["rtf"] = "word.exe"; // Value is now updated
        Console.WriteLine();
        foreach (var e in openWith) Console.WriteLine($"Key: {e.Key} Value: {e.Value}"); // ...Key: rtf Value: word.exe

        Console.WriteLine(openWith.ContainsKey("txt")); // true
        Console.WriteLine(openWith.ContainsValue("paint.exe")); // true

        new List<string>(openWith.Keys).ForEach(k => Console.WriteLine(k)); // txt, bmp, dib, rtf
        new List<string>(openWith.Values).ForEach(v => Console.WriteLine(v)); // notepad.exe, ..., word.exe
        */
        }
    }

    //Exercise:
    //1.    Use Rectangle from Example6_09 and implement a Dictionary that from a SortedSet<T> extracts the largest Rectangle of each Color. 
    //      Printout the result
}
