using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "God of War", "Stranger Things", "Halo", "Call of Duty"};
            var videoGamesLength = videoGames.OrderByDescending(x => x.Length);
            foreach(var game in videoGamesLength)
            {
                Console.WriteLine(game);
            }
            
        }
    }
}
