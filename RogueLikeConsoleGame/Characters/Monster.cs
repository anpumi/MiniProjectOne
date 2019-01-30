using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Monster
    {


        private int healthPoints;
        private string name;
        private int damagePoints;
        private int defendPoints;


        public static void StartGame()
        {


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
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong value, the value should be >= 0 and <= 10.");
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

                {
                    this.name = value;
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
                if (value >= 0 && value <= 20)
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


        public Monster()
        {

        }


        public void Strike()
        {
            throw new NotImplementedException();
        }



        Random rnd = new Random();

        public Monster(string name = "Monsteripelle", int health = 0, int damage = 0, int defend = 0)
        {

            this.Name = name;
            this.healthPoints = health;
            this.damagePoints = damage;
            this.defendPoints = defend;
        }

        // Generate random attack value for Player "pellehermanni";

        public int Attack()
        {
            return rnd.Next(1, (int)damagePoints);
        }




    }
}



