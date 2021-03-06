using System;
using System.Linq;
using System.Collections.Generic;

namespace helloCSharp
{
    class Monster
    {
        public string Species { get; set; }
        public int HitPoints { get; set; }
        public int GoldPieces { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("current time: " + DateTime.Now);
            Console.WriteLine("=======");
            QueryMonsters();
            Console.WriteLine("=======");
            QueryArray();
        }

        static void QueryMonsters()
        {
            IList<Monster> monsters = new List<Monster>() {
                new Monster() { Species = "orc" , HitPoints = 6, GoldPieces = 3 },
                new Monster() { Species = "gnoll" , HitPoints = 7, GoldPieces = 4 },
                new Monster() { Species = "minotaur" , HitPoints = 38, GoldPieces = 25 },
                new Monster() { Species = "dragon" , HitPoints = 97, GoldPieces = 1234 }
            };

            var powerfulMonsters = from m in monsters
                                   where m.HitPoints > 25
                                   select m;

            foreach (Monster monster in powerfulMonsters)
            {
                Console.WriteLine(monster.Species + " has " + monster.HitPoints + " hit points.");
            }
        }

        static void QueryArray()
        {
            int[] arr = {1, 2, 3};
            var query = arr.Select(n => Math.Pow(2, n));
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }

}
