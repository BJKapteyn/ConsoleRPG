using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta.Monsters
{
    class Bloke : IAdversary
    {
        public string Name { get; set; }
        public int Mass { get; set; }
        public int Intelligence { get; set; }
        public int Attitude { get; set; }
        public int Health { get; set; }

        public bool IsHairCool { get; set; }

        public Bloke()
        {
            Name = "Test Subject";
            Mass = 20;
            Intelligence = 20;
            Attitude = 20;
            Health = 100;
        }
        public Bloke(string name, int mass, int intell, int att, int health)
        {
            Name = name;
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

    }
}
