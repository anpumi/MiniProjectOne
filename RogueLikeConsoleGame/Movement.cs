using System;
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
        private static Player killer;
        public static void StartPosition()
        {
            CurrentPlayerPositionTop = Console.CursorTop = 10;
            CurrentPlayerPositionLeft = Console.CursorLeft = 20;
            Console.Write("@");
            Console.Write("\b");
        }

        public static void PlayGame(Player killer)
        {
            Movement.killer = killer;
            Move();
        }

        public static void Move()
        {
            Monster enemy = new Monster(40, 25, 0);
            //Console.CursorVisible = false;
            Arena.CreateArena();
            StartPosition();
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

                // Prevents walking through walls
                bool wall = Arena.IsWall(NewPlayerPositionLeft, NewPlayerPositionTop);

                if (wall)
                {
                    Console.Write("\b");
                    continue;
                }
                if (!wall)
                {
                    CurrentPlayerPositionTop = NewPlayerPositionTop;
                    CurrentPlayerPositionLeft = NewPlayerPositionLeft;
                    Console.CursorTop = OldPlayerPositionTop;
                    Console.CursorLeft = OldPlayerPositionLeft;
                    Console.Write(" ");
                    Console.CursorTop = CurrentPlayerPositionTop;
                    Console.CursorLeft = CurrentPlayerPositionLeft;
                    Console.Write("@");
                    Console.Write("\b");
                }

                if (Arena.IsMonster(NewPlayerPositionLeft,NewPlayerPositionTop))
                {
                    Battle.GetAttackResult(killer, enemy);
                    Arena.monsterElements[NewPlayerPositionLeft, NewPlayerPositionTop] = '\0';
                }
                
                if (Arena.IsChest(NewPlayerPositionLeft, NewPlayerPositionTop))
                {
                    Chest.DropLoot();
                    Arena.chestElements[NewPlayerPositionLeft, NewPlayerPositionTop] = '\0';
                }

                if (CurrentPlayerPositionLeft == Arena.ExitPositionLeft && CurrentPlayerPositionTop == Arena.ExitPositionTop)
                {
                    EndGame.Exit();
                }

            } while (input.Key != ConsoleKey.Escape);
        }
    }
}
