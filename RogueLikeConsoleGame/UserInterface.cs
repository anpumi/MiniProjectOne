using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class UserInterface
    {
        // Annukka Puotiniemi 30.1.2019
        public static void BuildUI()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("Player name: " + Player.name);
            Console.WriteLine("HP: " + Player.healthPoints);
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
    }
}
