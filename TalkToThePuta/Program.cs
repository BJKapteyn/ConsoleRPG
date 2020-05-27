using System;
using TalkToThePuta.Monsters;

namespace TalkToThePuta
{
    class Program
    {
        static void Main(string[] args)
        {

            LilCleetus testCleet = new LilCleetus();
            Bloke testBloke = new Bloke();

            Battle.RegularFight(testCleet, testBloke);
            //StoryLine.GetWoke(testCleet);

            //LilCleetus character = StoryLine.CharacterCreater();

            //LilCleetus characterPt2 = StoryLine.GetWoke(character);

        }
    }
}
