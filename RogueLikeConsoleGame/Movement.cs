﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RogueLikeConsoleGame
{
    public class Movement // Timo Lehtikallio 29/1/2019
    {
        public static int CurrentPlayerPositionTop;
        public static int CurrentPlayerPositionLeft;
        public static int NewPlayerPositionTop;
        public static int NewPlayerPositionLeft;
        public static int OldPlayerPositionTop;
        public static int OldPlayerPositionLeft;

        public static void StartPosition()
        {
            CurrentPlayerPositionTop = Console.CursorTop = 10;
            CurrentPlayerPositionLeft = Console.CursorLeft = 20;
            Console.Write("@");
        }

        /*public static void TestArena()
        {
            char[,] arena2d = new char[2, 2] { { '.', '.' }, { '.', '.' } };
            Console.Write(arena2d[0, 0]);
            Console.WriteLine(arena2d[0, 1]);
            Console.Write(arena2d[1, 0]);
            Console.Write(arena2d[1, 1]);
        }*/

        public static void Move()
        {
            StartPosition();
            Arena.CreateArena();
            //TestArena();

            var input = Console.ReadKey();

            do
            {
                input = Console.ReadKey();
                OldPlayerPositionTop = CurrentPlayerPositionTop;
                OldPlayerPositionLeft = CurrentPlayerPositionLeft;
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow: // move.Y -= 1;
                        NewPlayerPositionTop = CurrentPlayerPositionTop - 1;
                        NewPlayerPositionLeft = CurrentPlayerPositionLeft;
                        break;

                    case ConsoleKey.LeftArrow: // move.X -= 1;
                        NewPlayerPositionTop = CurrentPlayerPositionTop;
                        NewPlayerPositionLeft = CurrentPlayerPositionLeft - 1;
                        break;

                    case ConsoleKey.DownArrow: // move.Y += 1;
                        NewPlayerPositionTop = CurrentPlayerPositionTop + 1;
                        NewPlayerPositionLeft = CurrentPlayerPositionLeft;
                        break;

                    case ConsoleKey.RightArrow: // move.X += 1;
                        NewPlayerPositionTop = CurrentPlayerPositionTop;
                        NewPlayerPositionLeft = CurrentPlayerPositionLeft + 1;
                        break;
                }

                CurrentPlayerPositionTop = NewPlayerPositionTop;
                CurrentPlayerPositionLeft = NewPlayerPositionLeft;

                Console.CursorTop = OldPlayerPositionTop;
                Console.CursorLeft = OldPlayerPositionLeft;
                Console.Write(" ");

                if (CurrentPlayerPositionLeft == Arena.MonsterPositionLeft && CurrentPlayerPositionTop == Arena.MonsterPositionTop)
                {
                    Console.WriteLine("Wololoo!");
                    //Player.Attack();
                }

                if (CurrentPlayerPositionLeft == Arena.ChestPositionLeft && CurrentPlayerPositionTop == Arena.ChestPositionTop)
                {
                    Console.WriteLine("HeiHei");
                    //Player.Loot();
                }

                Console.CursorTop = CurrentPlayerPositionTop;
                Console.CursorLeft = CurrentPlayerPositionLeft;


                bool wall = Arena.IsWall(CurrentPlayerPositionLeft, CurrentPlayerPositionTop);

                if (CurrentPlayerPositionTop == 1 || CurrentPlayerPositionTop == Console.WindowHeight-2)
                {
                    CurrentPlayerPositionTop = OldPlayerPositionTop;
                }
                if (CurrentPlayerPositionLeft == 1 || CurrentPlayerPositionLeft == Console.WindowWidth - 2)
                {
                    CurrentPlayerPositionLeft = OldPlayerPositionLeft;
                }
                Console.Write("@");


            } while (input.Key != ConsoleKey.Escape);

            
        }
    }
}
