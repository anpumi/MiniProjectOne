﻿
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



        //private int healthPoints;
        //private string name;
        //private int damagePoints;
        //private int defendPoints;



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
                    healthPoints = value;
           
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
                if (value.Length >= 3)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "wrong length of name, name should be between 3-12 characters long.");
                }
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
                if (value >= 0 && value <= 20)
                {
                    defendPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong defencepoints value, the value should be >= 0 and <= 30.");
                }

            }
        }


        public Player()
        {

        }

   



        Random rnd = new Random();

        public Player(string name, int health ,int damage, int defend)
        {

            Name = name;
            healthPoints = health;
            damagePoints = damage;
            defendPoints = defend;
            this.WeaponMaster = new Katana();
            this.BodyArmor = new Armor();
        }

        // Generate random attack value for Player "pellehermanni"; TÄMÄ OSIO ON VIELÄ KESKEN!

        public int Attack()
        {
            return rnd.Next(10, (int)damagePoints);
        }

            //return rnd.Next(1, (int) damagePoints);

        public int Defence()
        {
            return defendPoints;
        }

    }
}
        








