using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    interface IAdversary
    {
        //All monsters will inherit from this class
        public string Name { get; set; }
        public int Mass { get; set; }
        public int Intelligence { get; set; }
        public int Attitude { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack();
    }
}
