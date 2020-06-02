using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta.Weapons
{
    class ShinyDagger : IWeapon
    {
        public string Name { get; set; } = "Shiny Dagger";
        public int MinDamage { get; set; } = 1;
        public int MaxDamage { get; set; } = 2;
    }
}
