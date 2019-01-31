using System;


namespace RogueLikeConsoleGame
{
    class Program
    {
        public static void Main()
        {
            Player killer = StartGame.Start();
            Movement.PlayGame(killer);
        }
    }
}
