﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Chest // Timo Lehtikallio
    {
        public static string[] ChestLoot = new string[] { "Mace", "Long Sword", "Battle Axe", "Ring Mail", "Scale Mail", "Plate Mail", "Health Potion" };

        public static void DropLoot()
        {
            Random randomLoot = new Random();
            int loot = randomLoot.Next(0, 6);
            switch (loot) // Player gains damage, defence or health randomly // If player already has the item, gives +10 health instead
            {
                case 0: // Player damage = 20
                    if (Player.damagePoints >= 20)
                    {
                        Player.healthPoints += 10;
                    }
                    else
                    {
                        Player.damagePoints = 20;
                        UserInterface.CurrentWeapon = ChestLoot[0];
                        UserInterface.CurrentWeaponDmg = 20;
                    }
                    break;

                case 1: // Player damage = 30
                    if (Player.damagePoints >= 30)
                    {
                        Player.healthPoints += 10;
                    }
                    else
                    {
                        Player.damagePoints = 30;
                        UserInterface.CurrentWeapon = ChestLoot[1];
                        UserInterface.CurrentWeaponDmg = 30;
                    }
                    break;

                case 2: // Player damage = 40
                    if (Player.damagePoints >= 40)
                    {
                        Player.healthPoints += 10;
                    }
                    else
                    {
                        Player.damagePoints = 40;
                        UserInterface.CurrentWeapon = ChestLoot[2];
                        UserInterface.CurrentWeaponDmg = 40;
                    }
                    break;

                case 3: // Player defence = 5 // Before 10
                    if (Player.defendPoints >= 5)
                    {
                        Player.healthPoints += 10;
                    }
                    else
                    {
                        Player.defendPoints = 5;
                        UserInterface.CurrentArmor = ChestLoot[3];
                        UserInterface.CurrentArmorDef = 5;
                    }
                    break;

                case 4: // Player defence = 10 // Before 15
                    if (Player.defendPoints >= 10)
                    {
                        Player.healthPoints += 10;
                    }
                    else
                    {
                        Player.defendPoints = 10;
                        UserInterface.CurrentArmor = ChestLoot[4];
                        UserInterface.CurrentArmorDef = 10;
                    }
                    break;

                case 5: // Player defence = 15 // Before 20
                    if (Player.defendPoints >= 15)
                    {
                        Player.healthPoints += 10;
                    }
                    else
                    {
                        Player.defendPoints = 15;
                        UserInterface.CurrentArmor = ChestLoot[5];
                        UserInterface.CurrentArmorDef = 15;
                    }
                    break;

                case 6: // Player health + 50
                    Player.healthPoints += 50;
                    break;
            }
            UserInterface.BuildUI();
        }
    }
}
