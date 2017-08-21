using System;
using System.Collections.Generic;

namespace kill_nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

            allSongs.Add(("Gravity", "John Mayer"));
            allSongs.Add(("Photograph", "Nickelback"));
            allSongs.Add(("Far Away", "Nickelback"));
            allSongs.Add(("Ants Marching", "Dave Matthews"));
            allSongs.Add(("Someday", "Nickelback"));
            allSongs.Add(("How you remind me", "Nickelback"));
            allSongs.Add(("What's Goin On", "Marvin Gaye"));

            foreach(var song in allSongs)
            {
                if (song.Item2 != "Nickelback")
                {
                    goodSongs.Add(song);
                }
            }

            foreach(var song in goodSongs)
            {
                Console.WriteLine($"{song.Item1} by {song.Item2}");
            }
        }
    }
}
