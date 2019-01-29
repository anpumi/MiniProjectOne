using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    public class Movement
    {
        public static void Move()
        {
            var input = Console.ReadKey();

            do
            {
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.W:
                        break;
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.S:
                        break;
                    case ConsoleKey.D:
                        break;
                }
            } while (input.Key != ConsoleKey.Escape);
        }
    }
}
