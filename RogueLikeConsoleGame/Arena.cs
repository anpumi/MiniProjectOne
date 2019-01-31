using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    // Annukka Puotiniemi 29/1/2019
    class Arena
    {
        // MONSTER elements and bool
        public const char monsterElement = 'M';
        public static int MonsterPositionTop;
        public static int MonsterPositionLeft;
        public static int[,] monsterElements = new int[Console.WindowWidth, Console.WindowHeight];
        public static bool IsMonster(int a, int b)
        {
            return monsterElements[a, b] == monsterElement;
        }

        // CHEST elements and bool
        public const char chestElement = 'C';
        public static int ChestPositionTop;
        public static int ChestPositionLeft;
        public static int[,] chestElements = new int[Console.WindowWidth, Console.WindowHeight];
        public static bool IsChest(int a, int b)
        {
            return chestElements[a, b] == chestElement;
        }

        // EXIT elements and bool
        public static int ExitPositionTop;
        public static int ExitPositionLeft;


        // WALL elements and bool
        public const char wallElement = '#';

        public static int x = Console.WindowWidth;
        public static int y = Console.WindowHeight;
        public static int[,] wallElements = new int[x, y];

        public static bool IsWall(int x, int y)
        {
            return wallElements[x, y] == wallElement;
        }

        //Exit();
        public static void CreateArena()
        {

            UserInterface.BuildUI();

            // Top border
            for (int i = 0; i < x; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = 6;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(wallElement);
                Console.ResetColor();
                wallElements[i, 6] = wallElement;
            }

            // Bottom border
            for (int i = 0; i < x; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = y - 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(wallElement);
                Console.ResetColor();
                wallElements[i, y-1] = wallElement;
            }

            // Left border
            for (int i = 6; i < y; i++)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = i;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(wallElement);
                Console.ResetColor();
                wallElements[0, i] = wallElement;
            }

            // Right border
            for (int i = 6; i < y; i++)
            {
                Console.CursorLeft = x - 1;
                Console.CursorTop = i;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(wallElement);
                Console.ResetColor();
                wallElements[x-1, i] = wallElement;
            }

            // wall1
            for (int i = 0; i < 15; i++)
            {
                Console.CursorLeft = 8;
                Console.CursorTop = i + 6;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[8, i + 6] = wallElement;
                wallElements[9, i + 6] = wallElement;
            }

            // wall2
            for (int i = 0; i < 12; i++)
            {
                Console.CursorLeft = 19;
                Console.CursorTop = i + 18;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[19, i + 18] = wallElement;
                wallElements[20, i + 18] = wallElement;
                wallElements[21, i + 18] = wallElement;
                wallElements[22, i + 18] = wallElement;
                wallElements[23, i + 18] = wallElement;
                wallElements[24, i + 18] = wallElement;
            }

            // wall3
            for (int i = 0; i < 19; i++)
            {
                Console.CursorLeft = 46;
                Console.CursorTop = i + 10;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[46, i + 10] = wallElement;
                wallElements[47, i + 10] = wallElement;
                wallElements[48, i + 10] = wallElement;
                wallElements[49, i + 10] = wallElement;
                wallElements[50, i+10] = wallElement;
                wallElements[51, i+10] = wallElement;
                wallElements[52, i+10] = wallElement;
            }
            // wall4
            for (int i = 0; i < 18; i++)
            {
                Console.CursorLeft = 65;
                Console.CursorTop = i + 6;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[65, i + 6] = wallElement;
                wallElements[66, i + 6] = wallElement;
                wallElements[67, i + 6] = wallElement;
            }

            // wall4
            for (int i = 0; i < 18; i++)
            {
                Console.CursorLeft = 30;
                Console.CursorTop = i + 6;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[30, i + 6] = wallElement;
                wallElements[31, i + 6] = wallElement;
                wallElements[32, i + 6] = wallElement;
                wallElements[33, i + 6] = wallElement;
                wallElements[34, i + 6] = wallElement;
                wallElements[35, i + 6] = wallElement;
            }
            // wall5
            for (int i = 0; i < 10; i++)
            {
                Console.CursorLeft = 80;
                Console.CursorTop = i + 20;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[80, i+20] = wallElement;
                wallElements[81, i+20] = wallElement;
                wallElements[82, i+20] = wallElement;
                wallElements[83, i+20] = wallElement;
            }

            // wall5
            for (int i = 0; i < 10; i++)
            {
                Console.CursorLeft = 78;
                Console.CursorTop = i + 7;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[78, i + 7] = wallElement;
                wallElements[79, i + 7] = wallElement;
                wallElements[80, i + 7] = wallElement;
                wallElements[81, i + 7] = wallElement;
                wallElements[82, i + 7] = wallElement;
                wallElements[83, i + 7] = wallElement;
                wallElements[84, i + 7] = wallElement;
                wallElements[85, i + 7] = wallElement;
            }
            // wall6
            for (int i = 0; i < 18; i++)
            {
                Console.CursorLeft = 100;
                Console.CursorTop = i + 7;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}{wallElement}");
                Console.ResetColor();
                wallElements[100, i+7] = wallElement;
                wallElements[101, i+7] = wallElement;
                wallElements[102, i+7] = wallElement;
                wallElements[103, i+7] = wallElement;
                wallElements[104, i+7] = wallElement;
                wallElements[105, i+7] = wallElement;
            }

            // Monster
            MonsterPositionLeft = Console.CursorLeft = 60;
            MonsterPositionTop = Console.CursorTop = 10;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(monsterElement);
            Console.ResetColor();
            monsterElements[60, 10] = monsterElement;

            MonsterPositionLeft = Console.CursorLeft = 80;
            MonsterPositionTop = Console.CursorTop = 18;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(monsterElement);
            Console.ResetColor();
            monsterElements[80, 18] = monsterElement;

            MonsterPositionLeft = Console.CursorLeft = 33;
            MonsterPositionTop = Console.CursorTop = 27;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(monsterElement);
            Console.ResetColor();
            monsterElements[33, 27] = monsterElement;

            // Chest
            ChestPositionLeft = Console.CursorLeft = 71;
            ChestPositionTop = Console.CursorTop = 7;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(chestElement);
            Console.ResetColor();
            chestElements[71, 7] = chestElement;

            ChestPositionLeft = Console.CursorLeft = 26;
            ChestPositionTop = Console.CursorTop = 28;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(chestElement);
            Console.ResetColor();
            chestElements[26, 28] = chestElement;

            // Exit
            ExitPositionLeft = Console.CursorLeft = 3;
            ExitPositionTop = Console.CursorTop = 27;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("%");
            Console.ResetColor();

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

