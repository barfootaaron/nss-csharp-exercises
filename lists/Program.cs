using System;
// using System.Linq;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args) 
        {     
            List<string> planetList = new List<string>()
            {
                "Mercury",
                "Mars"
            };

            // Add Jupiter and Saturn to the list
            planetList.Add("Jupiter"); 
            planetList.Add("Saturn");

            // Create list of last two planets then add to planetList
            List<string> lastTwo = new List<string>()
            {
                "Uranus",
                "Neptune"
            };
            planetList.AddRange(lastTwo);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            foreach (string p in planetList)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----------");

            planetList.Remove("Pluto");
            foreach (string p in planetList)
            {
                Console.WriteLine(p);
            }

            // Now that all the planets are in the list, slice the list using GetRange() 
            // in order to extract the rocky planets into a new list called rockyPlanets.
            Console.WriteLine("-------");
            Console.WriteLine("Rocky Planets:");

            string[] rockyPlanets = planetList.GetRange(0, 3).ToArray();
            
            foreach(string p in rockyPlanets)
            {
                Console.WriteLine(p);
            }

            // Mercury - Mariner 10, Messenger
            // Venus - Sputnik 7, Mariner 1
            // Earth-  Hubble
            // Mars - Zond 2, Mars 1
            // Jupiter - Pioneer 10, Ulysses
            // Saturn - Voyager 1, Cassini
            // Uranus - Voyager 2
            // Neptune - Voyager 2

            // Voyager 2-  Neptune Uranus
            // Cassini - Saturn, Jupiter, Venus

            // List<string> spacecraft = new List<string>();

            Dictionary<string, string> spacecraft = new Dictionary<string, string>();
        }
    }
}
