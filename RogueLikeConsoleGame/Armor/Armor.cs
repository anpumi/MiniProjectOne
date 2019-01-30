using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame.Armor
{
    public class Armor
    {
        private int armordefence;

        public int ArmorDefence
        {
            get
            {
                return this.armordefence;
            }
            private set
            {
                if (value >= 0)
                {
                    this.armordefence = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor have to be a positive number");
                }
            }
        }





        public Armor()
        {
            this.ArmorDefence = 20;
        }
            
    }
}
        //public static string ArmorName;
        //public static int Effectiveness;
