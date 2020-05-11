using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    class Buff
    {
        public string BuffName;
        public int Modifier;

        public Buff(string buffName, int modifier)
        {
            BuffName = buffName;
            Modifier = modifier;
        }
    }
}
