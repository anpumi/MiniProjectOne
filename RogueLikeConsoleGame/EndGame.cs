﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class EndGame // Timo Lehtikallio
    {
        public static string input = "";
        
        public static void Exit()
        {
            Console.WriteLine("Good shit bro, you win!");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Wanna play again - YES/NO?");
                input = Console.ReadLine().ToUpper();
            } while (input != "NO" && input != "YES");

            if (input == "YES")
            {
                //Program.Main();
            }

            if (input == "NO")
            {
                Environment.Exit(0);
            }
        }

        public static void GameOver()
        {
            Console.WriteLine("YOU DIED");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Wanna play again - YES/NO?");
                input = Console.ReadLine().ToUpper();
            } while (input != "NO" && input != "YES");

            if (input == "YES")
            {
                //Program.Main();
            }

            if (input == "NO")
            {
                Environment.Exit(0);
            }
        }
    }
}
