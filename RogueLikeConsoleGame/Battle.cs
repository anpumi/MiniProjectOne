using RogueLikeConsoleGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Battle
    {
        //public static void StartFight(Player pelaaja, Monster monsteri)
        //{
        //    while (true)
        //    {
        //        //if (GetAttackResult(pelaaja, monsteri) == "Game over")
        //        //{
        //        //    Console.WriteLine("Game lost");
        //        //}
        //    }
        //}

        //public static string GetAttackResult(Player playerA, Monster monsterB)
        public static void GetAttackResult(Player playerA, Monster monsterB)
        {
            //bool isPlayerDead = false;
            //bool isMonsterDead = false;
            bool dead = false;

            //PLayer spesification
            int warAttack = playerA.Attack();
            int warDefence = monsterB.Defence();
            int warIsHellB = -warDefence + warAttack;

            //Monster spesification
            int warAttack2 = monsterB.Attack();
            int warDefence2 = playerA.Defence();
            int warisHellA = -warDefence2 + warAttack2;

            do
            {
                // Player hits monster
                if (warIsHellB > 0)
                {
                    monsterB.HealthPoints = monsterB.HealthPoints - warIsHellB;
                    UserInterface.Text = "fsdafasd";
                }

                else
                {
                    warIsHellB = 0;
                    UserInterface.Text = "fsdafasd";
                }

                // Monster hits player
                if (warisHellA > 0)
                {
                    playerA.HealthPoints = playerA.HealthPoints - warisHellA;
                }

                else
                {
                    warisHellA = 0;
                }

                // Monster dies
                if (monsterB.HealthPoints <= 0)
                {
                    //Console.WriteLine("{0} has DIED and {1} is Bestofthebest\n", monsterB.Name, playerA.Name);
                    //return "Game over";
                    dead = true;
                }

                // Player dies
                if (playerA.HealthPoints <= 0)
                {
                    dead = true;
                    EndGame.GameOver();
                }
            } while (!dead);
        }
    }
}