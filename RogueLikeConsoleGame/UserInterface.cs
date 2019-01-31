using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class UserInterface
    {
        // Annukka Puotiniemi 30.1.2019
        public static string CurrentWeapon = "Dagger";
        public static int CurrentWeaponDmg = 10;
        public static string CurrentArmor = "None";
        public static int CurrentArmorDef = 0;
        public static string Text = "";
        public static string Text2 = "";

        public static void BuildUI()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine($"Player name: {Player.name} \t {Text} {Text2} \t");
            Console.WriteLine($"HP: {Player.healthPoints} \t\t");
            //Console.WriteLine($"HP: {Player.healthPoints} \t\t {Text2}");
            Console.WriteLine($"Weapon: {CurrentWeapon}, Damage: {CurrentWeaponDmg} \t\t");
            Console.WriteLine($"Armor: {CurrentArmor}, Defence: {CurrentArmorDef}");
            //Console.WriteLine();
            /*for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }*/
        }
    }
}
