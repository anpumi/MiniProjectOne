using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Arena
    {
        //Exit();
        public static void CreateArena()
        {
            // Annukka Puotiniemi 29/1/2019
            // Top border
            for (int i = 0; i < 120; i++)
            {
                Console.CursorTop = 0;
                Console.CursorLeft = i;
                Console.Write("#");
            }

            // Bottom border
            for (int i = 0; i < 120; i++)
            {
                Console.CursorTop = 29;
                Console.CursorLeft = i;
                Console.Write("#");
            }

            // Left border
            for (int i = 0; i < 30; i++)
            {
                Console.CursorTop = i;
                Console.CursorLeft = 0;
                Console.Write("#");
            }

            // Right border
            for (int i = 0; i < 30; i++)
            {
                Console.CursorTop = i;
                Console.CursorLeft = 119;
                Console.Write("#");
            }

            // wall1
            for (int i = 0; i < 30; i++)
            {
                Console.CursorTop = 20;
                Console.CursorLeft = i;
                Console.Write("1");
            }

            // wall2
            for (int i = 0; i < 10; i++)
            {
                Console.CursorTop = i;
                Console.CursorLeft = 50;
                Console.Write("2");
            }

            // wall3
            for (int i = 0; i < 10; i++)
            {
                Console.CursorTop = i + 20;
                Console.CursorLeft = 80;
                Console.Write("3");
            }

            // wall4
            for (int i = 0; i < 10; i++)
            {
                Console.CursorTop = i + 10;
                Console.CursorLeft = 100;
                Console.Write("4");
            }

            // Monster

            Console.CursorTop = 10;
            Console.CursorLeft = 60;
            Console.Write("M");

            // Chest
            Console.CursorTop = 18;
            Console.CursorLeft = 20;
            Console.Write("C");
        }
    }
}

