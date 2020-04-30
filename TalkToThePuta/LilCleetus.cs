using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    class LilCleetus
    {
        public string Name = "Lil Cleetus";

        public int Mass;
        public int Intelligence;
        public int Attitude;
        public int Health;

        public LilCleetus(int mass, int intell, int att, int health)
        {
            Mass = mass;
            Intelligence = intell;
            Attitude = att;
            Health = health;
        }
           
        public int Attack()
        {
            int attackDamage = Mass + 2;

            return attackDamage;
        }

        public int MagicAttack()
        {
            int attackDamage = Intelligence + 5;

            return attackDamage;
        }

        

    }
}
