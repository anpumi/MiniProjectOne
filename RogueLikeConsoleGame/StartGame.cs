using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class StartGame // Asko Pakkala / Timo Lehtikallio
    {
        public static void Start()
        {
            Console.WriteLine("Please enter Player name: ");
            string name1 = Console.ReadLine();
            Console.Clear();
            string name2 = "MonsteriPelle";
            Player killer = new Player(name1, 100, 10, 0);
            Monster enemy = new Monster(name2, 40, 40, 0);
        }
    }
}
