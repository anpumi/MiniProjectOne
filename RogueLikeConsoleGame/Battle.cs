using RogueLikeConsoleGame;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RogueLikeConsoleGame
{
    class Battle
    {
        public static void GetAttackResult(Player playerA, Monster monsterB)
        {
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
                    UserInterface.Text = "Player dmg: " + warIsHellB + ", monster hp: " + monsterB.HealthPoints + "";
                }

                else
                {
                    warIsHellB = 0;
                    UserInterface.Text = "Player dmg: " + warIsHellB + ", monster hp: " + monsterB.HealthPoints + "";
                }

                // Monster hits player
                if (warisHellA > 0)
                {
                    playerA.HealthPoints = playerA.HealthPoints - warisHellA;
                    UserInterface.Text2 = "|| Monster dmg: " + warisHellA + ", player hp: " + playerA.HealthPoints + "";
                }

                else
                {
                    warisHellA = 0;
                    UserInterface.Text2 = "|| Monster dmg: " + warisHellA + ", player hp: " + playerA.HealthPoints + "";
                }

                // Monster dies
                if (monsterB.HealthPoints <= 0)
                {
                    UserInterface.Text = "Monster died" + "\t\t\t\t\t\t\t";
                    UserInterface.Text2 = " ";
                    dead = true;
                }

                // Player dies
                if (playerA.HealthPoints <= 0)
                {
                    UserInterface.Text = "\t\t\t\t";
                    UserInterface.Text2 = "\t\t\t\t";
                    dead = true;
                    EndGame.GameOver();
                }
                UserInterface.BuildUI();
                Thread.Sleep(1000);
            } while (!dead);
            monsterB.HealthPoints = 40;
            UserInterface.Text = "\t\t\t\t";
            UserInterface.Text2 = "\t\t\t\t";
            UserInterface.BuildUI();
        }
    }
}