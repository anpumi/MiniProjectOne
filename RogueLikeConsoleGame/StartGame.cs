using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class StartGame // Asko Pakkala / Timo Lehtikallio / Annukka Puotiniemi
    {
        public static Player Start()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("Welcome to the Codes of Exploration!");
            Console.WriteLine();
            Console.WriteLine("Move around the arena using keyboard arrows. Avoid the monsters, ");
            Console.WriteLine("open chests to collect loot, and exit the game from % ");
            Console.WriteLine();
            Console.WriteLine("@ = player");
            Console.WriteLine("# = walls");
            Console.WriteLine("C = chest");
            Console.WriteLine("M = monster");
            Console.WriteLine("% = exit");
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("Please enter player name: ");
            string name1 = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Welcome to the game, " + name1 + ". Let's get started!");
            //Console.WriteLine("Press enter to continue...");
            //Console.WriteLine();

            Console.Clear();
            Player killer = new Player(name1, 100, 10, 0);
            
            return killer;
        }
    }
}
