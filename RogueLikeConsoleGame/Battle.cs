using RogueLikeConsoleGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Battle
    {
        public static void StartFight(Player pelaaja, Monster monsteri)
        {
            while (true)
            {
                if (GetAttackResult(pelaaja, monsteri) == "Game over")
                {
                    Console.WriteLine("GAME LOST HAHAAHAH");
                    break;
                }

            }
        }

        public static string GetAttackResult(Player playerA, Monster monsterB)
        {
            int warAttack = playerA.Attack();

            int warDefence = monsterB.Defence();

            int warIsHellB = warDefence-warAttack;

            if (warIsHellB > 0)
            {
                monsterB.HealthPoints = monsterB.HealthPoints- warIsHellB;
            }
            //else
            //{
            //    warIsHellB = 0;
            //}

            Console.ReadLine();


            Console.WriteLine("{0} Attack {1} and deals {2} damage", playerA.Name, monsterB.Name, warIsHellB);
            Console.WriteLine("{0} has {1} Health \n", monsterB.Name, monsterB.HealthPoints);

            if (monsterB.HealthPoints <= 0)
            {
                Console.WriteLine("{0} has DIED and {1} is Bestofthebest\n", monsterB.Name, playerA.Name);
                return "Game over";
            }
            else
            {
                return "Fight again";
            }
        }
    }
}







