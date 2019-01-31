
using RogueLikeConsoleGame;

using System;
using System.Collections.Generic;
using System.Text;


namespace RogueLikeConsoleGame
{
    public class Player
    {
        private Armor bodyArmor;
        private Katana weaponMaster;

        public static int healthPoints;
        public static string name;
        public static int damagePoints;
        public static int defendPoints;

        public static void StartGame()
        {

        }

        public Katana WeaponMaster
        {
            get
            {
                return this.weaponMaster;
            }
            set
            {
                this.weaponMaster = value;
            }
        }

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                {
                    if (healthPoints > 100)
                    {
                        healthPoints = 100;
                    }
                    else
                    {

                        healthPoints = value;
                    }
                }

            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }
            set
            {
                damagePoints = value;

            }
        }

        public int DefendPoints
        {
            get
            {
                return defendPoints;
            }
            set
            {
                defendPoints = value;
            }
        }

        public Player()
        {

        }

        Random rnd = new Random();

        public Player(string name, int health, int damage, int defend)
        {
            Name = name;
            healthPoints = health;
            damagePoints = damage;
            defendPoints = defend;
            this.WeaponMaster = new Katana();
            this.BodyArmor = new Armor();
        }

        public int Attack()
        {
            return rnd.Next(damagePoints-5, (int)damagePoints);
        }

        public int Defence()
        {
            return defendPoints;
        }
    }
}









