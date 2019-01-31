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

            do
            {
                //PLayer spesification
                int warAttack = playerA.Attack();
                int warDefence = monsterB.Defence();
                int warIsHellB = -warDefence + warAttack;

                //Monster spesification
                int warAttack2 = monsterB.Attack();
                int warDefence2 = playerA.Defence();
                int warisHellA = -warDefence2 + warAttack2;

                if (warIsHellB > 0)
                {
                    monsterB.HealthPoints = monsterB.HealthPoints - warIsHellB;
                }

                else
                {
                    warIsHellB = 0;
                }

                if (warisHellA > 0)
                {
                    playerA.HealthPoints = playerA.HealthPoints - warisHellA;
                }

                else
                {
                    warisHellA = 0;
                }

                if (monsterB.HealthPoints <= 0)
                {
                    //Console.WriteLine("{0} has DIED and {1} is Bestofthebest\n", monsterB.Name, playerA.Name);
                    //return "Game over";
                }

                //else
                //{
                //    return " ";
                //}

                if (playerA.HealthPoints <= 0)
                {
                    EndGame.GameOver();
                }
            } while (!dead);
        }
    }
}