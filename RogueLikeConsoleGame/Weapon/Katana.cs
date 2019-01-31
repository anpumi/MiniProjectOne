using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLikeConsoleGame
{

    public class Katana
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value >= 0)
                {
                   this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage have to be a positive number");
                }
            }
        }
        public Katana()
        {
            this.Damage = 10;
        }
    }
}
      