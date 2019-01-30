
using RogueLikeConsoleGame;
using RogueLikeConsoleGame.Armor;
using System;
using System.Collections.Generic;
using System.Text;


namespace Characters
{
    public class Player
    {

        private Armor bodyArmor;
        private Katana weaponMaster;

        private int healthPoints;
        private string name;
        private int damagePoints;
        private int defendPoints;


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
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "wrong value, the value should be >= 0 and <= 10.");
                }

            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3)
                {
                    this.name = value;
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
                return this.damagePoints;
            }
            set
            {
                if (value >= 0 && value <= 40)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong value, the value should be >= 0 and <= 10.");
                }

            }
        }

        public int DefendPoints
        {
            get
            {
                return this.defendPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.defendPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong value, the value should be >= 0 and <= 10.");
                }

            }
        }


        public Player()
        {

        }


        //public void Strike()
        //{
        //    throw new NotImplementedException();
        //}





        Random rnd = new Random();

        public Player(string name = "Pellehermanni", int health = 0, int damage=0, int defend = 0)
        {

            this.Name = name;
            this.healthPoints = health;
            this.damagePoints = damage;
            this.defendPoints = defend;
            this.WeaponMaster = new Katana();
            this.BodyArmor = new Armor();
        }

        // Generate random attack value for Player "pellehermanni"; TÄMÄ OSIO ON VIELÄ KESKEN!

        public int Attack()
        {
            return rnd.Next(1, (int)damagePoints);
        }


    }
}
        








