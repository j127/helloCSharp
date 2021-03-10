using System;
using System.Linq;

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

            QueryMonsters();
            QueryArray();
        }

        static void QueryMonsters()
        {
            Monster[] monsters = {
                new Monster() { Species = "orc" , HitPoints = 6, GoldPieces = 3 },
                new Monster() { Species = "gnoll" , HitPoints = 7, GoldPieces = 4 },
                new Monster() { Species = "minotaur" , HitPoints = 38, GoldPieces = 25 },
                new Monster() { Species = "dragon" , HitPoints = 97, GoldPieces = 1234 }
            };

            Monster[] powerfulMonsters = monsters.Where(m => m.HitPoints > 25).ToArray();

            foreach (var monster in powerfulMonsters)
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

        // static void Query

    }

}
