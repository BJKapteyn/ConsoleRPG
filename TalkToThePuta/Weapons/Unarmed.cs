using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta.Weapons
{
    class Unarmed : IWeapon
    {
        public string Name { get; set; } = "Your mits";
        public int MinDamage { get; set; } = 0;
        public int MaxDamage { get; set; } = 1;
    }
}
