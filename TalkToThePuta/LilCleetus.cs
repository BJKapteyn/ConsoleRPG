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

        public List<Item> ItemBag;


        public LilCleetus(int mass, int intell, int att, int health)
        {
            Mass = mass;
            Intelligence = intell;
            Attitude = att;
            Health = health;
            ItemBag = new List<Item>();
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

        public void AddItem(Item stuff)
        {
            if(ItemBag.Count <= 10)
            {
                ItemBag.Add(stuff);
            }
            else
            {
                Console.WriteLine("There is not enough inventory space.");
            }
        }
        
    }
}
