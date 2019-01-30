using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class UserInterface
    {
        
        public void BuildUI()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("Player name: " + Characters.Player.name);
            Console.WriteLine("HP: " + Characters.Player.healthPoints);
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
    }
}
