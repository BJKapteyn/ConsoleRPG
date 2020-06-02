using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    interface IWeapon
    {
        string Name { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
    }
}
