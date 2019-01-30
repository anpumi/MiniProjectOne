using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Chest // Timo Lehtikallio
    {
        //Open();
        //DropLoot();

        public static string[] ChestLoot = new string[] { "Mace", "LongSword", "BattleAxe", "RingMail", "ScaleMail", "PlateMail", "HealthPotion" };

        public static void DropLoot()
        {
            Random randomLoot = new Random();
            int loot = randomLoot.Next(0, 6);
            //Console.WriteLine(ChestLoot[6]);
            //Console.WriteLine(ChestLoot.Length);
            //Console.WriteLine(loot);
            switch (loot)
            {
                case 0:
                    Console.Write("Player damage = 10");
                    // If player damage > 10 -> hp+5
                    // Else player damage = 20
                    break;
                case 1:
                    Console.Write("Player damage = 15");
                    // If player damage > 15 -> hp+5
                    // Else player damage = 20
                    break;
                case 2:
                    Console.Write("Player damage = 20");
                    // If player damage > 20 -> hp+5
                    // Else player damage = 20
                    break;
                case 3:
                    Console.Write("Player defence = 10");
                    // If player armor > 10 -> hp+5
                    // Else player armor = 10
                    break;
                case 4:
                    Console.Write("Player defence = 15");
                    // If player armor > 15 -> hp+5
                    // Else player armor = 15
                    break;
                case 5:
                    Console.Write("Player defence = 20");
                    // If player armor > 20 -> hp+5
                    // Else player armor = 20
                    break;
                case 6:
                    Console.Write("HelaaPRKL");
                    break;
                //case 7:
                //    Console.Write("HelaaPRKL");
                //    break;
            }

            
            //if (loot == 7)
            //{
            //    // Player health + 30
            //    Console.Write("HelaaPRKL");
            //}
        }
    }
}
