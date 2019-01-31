using System;


namespace RogueLikeConsoleGame
{
    class Program
    {
        public static void Main()
        {
            StartGame.Start();
            Movement.PlayGame();
            
            //Battle.StartFight(killer, enemy);
            //Battle.GetAttackResult(killer, enemy);
        }
    }
}
