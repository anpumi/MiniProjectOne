using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
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
       
                {
                    this.healthPoints = value;
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
                    this.damagePoints = value;
        
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

                {
                    this.defendPoints = value;
                }

            }
        }


        public Monster()
        {

        }


        Random rnd = new Random();


        public Monster(string name, int health, int damage, int defend)
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

        
        public int Defence()
        {
            return defendPoints;
        }




    }
}



