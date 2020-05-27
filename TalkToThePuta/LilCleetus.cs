using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    class LilCleetus
    {
        public string Name = "Lil Cleetus";
        public int Mass { get; set; }
        public int Intelligence { get; set; }
        public int Attitude { get; set; }
        public int Health { get; set; }

        public List<Item> ItemBag;


        public LilCleetus()
        {
            Mass = 20;
            Intelligence = 20;
            Attitude = 20;
            Health = 100;
            ItemBag = new List<Item>();
        }
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

        public void CheckItems()
        {
            if(ItemBag.Count == 0)
            {
                Console.WriteLine("You don't have anything in your pack.");
            }
            else
            {
                for(int i = 0; i < ItemBag.Count; i++)
                {
                    Console.WriteLine(ItemBag[i].Name + " - " + ItemBag[i].Description);
                }
            }
        }
        
    }
}
