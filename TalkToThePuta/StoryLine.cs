using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    class StoryLine
    {
        public static LilCleetus CharacterCreater()
        {
            Console.WriteLine("Welcome to this place, Lil Cleetus \nLet's Customize your Cleet");

            int pointsToSpend = 10;

            int mass = 5;
            int intelligence = 5;
            int attitude = 5;
            int health = 10;

            string sMass = mass.ToString();
            string sIntell = intelligence.ToString();
            string sAttitude = attitude.ToString();
            string sHealth = health.ToString();
            string sPoints = pointsToSpend.ToString();

            Console.WriteLine("\nHere are your stats:\n\n" +
                                $"1.     Mass:         {sMass}\n" +
                                $"2.     Intelligence: {sIntell}\n" +
                                $"3.     Attitude:     {sAttitude}\n" +
                                $"4.     Health:       {sHealth}\n");

            Console.WriteLine($"/nYou have {sPoints} good boy points\n Enter the number of good boy points you want to goop your mass stat up.");

            while (true)
            {
                Console.WriteLine($"Enter a number 1 to {sPoints}");
                string sAnswer = Console.ReadLine();

                int pointsToAdd = 0;

                bool isNumber = int.TryParse(sAnswer, out pointsToAdd);

                if (isNumber)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        mass += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sMass = mass.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"That's not a number between 0 and {pointsToSpend}");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number ya turkey");
                    continue;
                }
            }
            Console.Clear();
            Console.WriteLine("\nHere are your stats:\n\n" +
                                $"1.     Mass:         {sMass}\n" +
                                $"2.     Intelligence: {sIntell}\n" +
                                $"3.     Attitude:     {sAttitude}\n" +
                                $"4.     Health:       {sHealth}\n");

            Console.WriteLine($"You have {pointsToSpend} good boy points left.");

            while (true)
            {
                Console.WriteLine("How many points do you want to spend on intelligence");
                string sInt = Console.ReadLine();

                int pointsToAdd = 0;
                bool isNumber = int.TryParse(sInt, out pointsToAdd);

                if (isNumber == true)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        intelligence += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sIntell = intelligence.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That's too many or too few I don't feel like knowing the difference");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("That isn't a number I dun told ya");
                    continue;
                }
            }

            Console.Clear();
            Console.WriteLine("\nHere are your stats:\n\n" +
                                $"1.     Mass:         {sMass}\n" +
                                $"2.     Intelligence: {sIntell}\n" +
                                $"3.     Attitude:     {sAttitude}\n" +
                                $"4.     Health:       {sHealth}\n");

            Console.WriteLine($"You have {pointsToSpend} good boy points left.");
            while (true)
            {
                Console.WriteLine("How many points do you want to spend on Attitude");
                string sAtt = Console.ReadLine();

                int pointsToAdd = 0;
                bool isNumber = int.TryParse(sAtt, out pointsToAdd);

                if (isNumber == true)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        attitude += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sAttitude = attitude.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That's too many or too few I don't feel like knowing the difference");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("That isn't a number I dun told ya");
                    continue;
                }
            }

            Console.Clear();
            Console.WriteLine("\nHere are your stats:\n\n" +
                                $"1.     Mass:         {sMass}\n" +
                                $"2.     Intelligence: {sIntell}\n" +
                                $"3.     Attitude:     {sAttitude}\n" +
                                $"4.     Health:       {sHealth}\n");
            Console.WriteLine($"You have {pointsToSpend} good boy points left.");

            while (true)
            {
                Console.WriteLine("How many points do you want to spend on Health");
                string sHeal = Console.ReadLine();

                int pointsToAdd = 0;
                bool isNumber = int.TryParse(sHeal, out pointsToAdd);

                if (isNumber == true)
                {
                    if (pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        health += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sHealth = health.ToString();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That's too many or too few I don't feel like knowing the difference");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("That isn't a number I dun told ya");
                    continue;
                }
            }

            LilCleetus lilCleet = new LilCleetus(mass, intelligence, attitude, health);

            Console.WriteLine("That's great, Lil Cletus can't wait to party");
            Console.WriteLine($"Here are your final stats and {lilCleet.Mass.ToString()}" +
                $"\nHere is your final intelligence: {lilCleet.Intelligence.ToString()}" +
                $"\nHere is your final attitude: {lilCleet.Attitude.ToString()}" +
                $"\nHere is your final health: {lilCleet.Health.ToString()}");

            Console.WriteLine("Are you happy with these choices?(Y/N)");

            string doesntMatter = Console.ReadLine();
            doesntMatter = doesntMatter.ToLower();
            if (doesntMatter == "y")
            {
                Console.WriteLine("This is the correct answer, it's time to party");
            }
            else if (doesntMatter == "n")
            {
                CharacterCreater();
            }
            else
            {
                Console.WriteLine("I don't understand we're moving on, it's time to party");
            }

            return lilCleet;
        }

        public static LilCleetus GetWoke(LilCleetus lil)
        {
            Console.WriteLine("You wake up in a haze of sex drugs and fart clouds");

            return lil;
        }
    }
}
