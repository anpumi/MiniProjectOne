using System;
using Characters;

namespace RogueLikeConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Player name: ");
            string name1 = Console.ReadLine();
            string name2 = "MonsteriPelle";

            Player killer = new Player(name1, 100, 20, 15);
            //killer.Health += 10;

            Monster enemy = new Monster(name2, 40, 40, 20);



            Console.WriteLine($"Damage yhteensä aseen kanssa {killer.WeaponMaster.Damage + killer.DamagePoints}"); //Kokeilu paljon on playerin damage yhteensä katanan kanssa!
            Console.WriteLine($"Defence pisteet yhteensä armorin kanssa {killer.BodyArmor.ArmorDefence +  killer.DefendPoints}"); //Kokeilu paljon on pleijerin defence yhteensä armorin kanssa.
            // tähän tulee vielä muutoksia. Täytyy ottaa kokonaan defend ominaisuus pois ja korvata se armorilla
            Console.WriteLine($"Healthpisteet ovat {killer.HealthPoints}");

            Console.ReadLine();
            Console.Clear();
            //StartGame();
            //PlayGame();
            //EndGame();
            Movement.Move();
        }
    }
}
