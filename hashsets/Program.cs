using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> ShowRoom = new HashSet<string>();

            ShowRoom.Add("4Runner");
            ShowRoom.Add("Land Cruiser");
            ShowRoom.Add("Model X");
            ShowRoom.Add("Discovery");
            ShowRoom.Add("4Runner");
            // Console.WriteLine(ShowRoom.Count);

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Camry");
            UsedLot.Add("Model T");

            ShowRoom.UnionWith(UsedLot);
            // Console.WriteLine(ShowRoom.Count);

            ShowRoom.Remove("4Runner");
            // foreach(string car in ShowRoom) 
            // {
            //     Console.WriteLine(car);
            // }
            
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("FJ");
            Junkyard.Add("Range Rover Velar");
            Junkyard.Add("Camry");
            Junkyard.Add("Model X");

            // ShowRoom.IntersectWith(Junkyard);
            // foreach (string duplicate in ShowRoom) 
            // {
            //     Console.WriteLine(duplicate);
            // }

            ShowRoom.UnionWith(Junkyard);
            // foreach(string car in ShowRoom) 
            // {
            //     Console.WriteLine(car);
            // }

            ShowRoom.Remove("Range Rover Velar");            
            foreach(string car in ShowRoom) 
            {
                Console.WriteLine(car);
            }



        }
    }
}
