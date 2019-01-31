using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class UserInterface
    {
        // Annukka Puotiniemi 30.1.2019
        public static string CurrentWeapon = "";
        public static int CurrentWeaponDmg = 0;
        public static string CurrentArmor = "";
        public static int CurrentArmorDef = 0;

        public static void BuildUI()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("Player name: " + Player.name);
            Console.WriteLine("HP: " + Player.healthPoints);
            //Console.WriteLine("Weapon: " + Chest.ChestLoot);
            Console.WriteLine($"Weapon: {CurrentWeapon}, Damage: {CurrentWeaponDmg}");
            Console.WriteLine($"Armor: {CurrentArmor}, Defence: {CurrentArmorDef}");
            //Console.WriteLine();
            /*for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }*/
        }

        /*public static void BuildUI()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("Player name: " + Player.name);
            Console.WriteLine("HP: " + Player.healthPoints);
            //Console.WriteLine("Weapon: " + Chest.ChestLoot);
            Console.WriteLine($"Weapon: {CurrentWeapon}, Damage: {CurrentWeaponDmg}");
            Console.WriteLine($"Armor: {CurrentArmor}, Defence: {CurrentArmorDef}");
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
        }*/
    }
}
