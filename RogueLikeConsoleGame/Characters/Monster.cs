using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{
    class Monster // Asko Pakkala
    {
        public static int healthPoints;
       // public static string name;
        public static int damagePoints;
        public static int defendPoints;

        public static void StartGame()
        {


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

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {

        //        {
        //            name = value;
        //        }

        //    }
        //}

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

                {
                    defendPoints = value;
                }

            }
        }


        public Monster()
        {

        }

        Random rnd = new Random();

        public Monster(int health, int damage, int defend)
        {
            //Name = name;
           healthPoints = health;
           damagePoints = damage;
           defendPoints = defend;
        }

        // Generate random attack value for Player "Monster";

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
