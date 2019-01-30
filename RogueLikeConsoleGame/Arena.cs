using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Arena
    {
        public static int MonsterPositionTop;
        public static int MonsterPositionLeft;

        public static int ChestPositionTop;
        public static int ChestPositionLeft;

        public const char wallElement = '#';

        public static int x = Console.WindowWidth;
        public static int y = Console.WindowHeight;
        public static int[,] wallElements = new int[x, y];

        public static bool IsWall(int x, int y)
        {
            return wallElements[x, y] != '\0';
        }
        //Exit();
        public static void CreateArena()
        {
            // Annukka Puotiniemi 29/1/2019
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            // Top border
            for (int i = 0; i < x; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = 6;
                Console.Write(wallElement);
                wallElements[i, 6] = '#';
            }

            // Bottom border
            for (int i = 0; i < x; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = y - 1;
                Console.Write(wallElement);
                wallElements[i, y-1] = '#';
            }

            // Left border
            for (int i = 6; i < y; i++)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = i;
                Console.Write(wallElement);
                wallElements[0, i] = '#';
            }

            // Right border
            for (int i = 6; i < y; i++)
            {
                Console.CursorLeft = x - 1;
                Console.CursorTop = i;
                Console.Write(wallElement);
                wallElements[x-1, i] = '#';
            }

            // wall1
            for (int i = 0; i < 30; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = y - 10;
                Console.Write("1");
                wallElements[i, y - 10] = '1';
            }

            // wall2 - jatka tästä
            for (int i = 0; i < 6; i++)
            {
                Console.CursorLeft = 50;
                Console.CursorTop = i + 6;
                Console.Write("2");
                wallElements[50, i + 6] = '2';
            }

            // wall3
            for (int i = 0; i < 10; i++)
            {
                Console.CursorLeft = 80;
                Console.CursorTop = i + 20;
                Console.Write("3");
                wallElements[80, i + 20] = '3';
            }

            // wall4
            for (int i = 0; i < 10; i++)
            {
                Console.CursorLeft = 100;
                Console.CursorTop = i + 10;
                Console.Write("4");
                wallElements[100, i + 10] = '4';
            }

            // Monster
            MonsterPositionLeft = Console.CursorLeft = 60;
            MonsterPositionTop = Console.CursorTop = 10;
            Console.Write("M");

            // Chest
            ChestPositionLeft = Console.CursorLeft = 20;
            ChestPositionTop = Console.CursorTop = 18;
            Console.Write("C");


        }
        public static void DumpArena()
        {
            for (int y = 0; y <= wallElements.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= wallElements.GetUpperBound(0); x++)
                {
                    Console.Write((char)wallElements[x,y]);
                }
                    Console.WriteLine();
            }
        }
    }
}

