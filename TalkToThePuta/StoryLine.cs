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
            string playerChoice;

            Buff maskBuff = new Buff("Health", 2);
            Buff sunglassesBuff = new Buff("Attitude", 1);

            List<Buff> maskBuffs = new List<Buff>() { maskBuff };
            List<Buff> sunglassesBuffs = new List<Buff>() { sunglassesBuff };

            //descriptions
            string maskDes = "Nothing that cool about the mask other than the fangs you drew on it.";
            string sunglassDes = "Awesome pre-rag sunglasses that only have a few scratches on them.";

            Item mask = new Item("Face Mask" , maskDes, false, maskBuffs);
            Item sunglasses = new Item("Cool Sunglasses", sunglassDes, false, sunglassesBuffs);

            //for checking if actions were made or not
            bool didLookUnderNews = false;
            bool didLookInMirror = false;
            bool didCheckCloset = false;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("The morning has not been kind, You lack purpose and direction. You know you need to get outside. " +
                    "You need a mask and some cool sunglasses. " +
                    "\nThere is a dusty looking newspaper on the foot of your bed." +
                    "\nThere is mirror hanging from your sick mounted moose antlers." +
                    "\nThere is are snores coming from the closet" +
                    "\nOne thing you know is that you arent going outside without looking rad. Also you'd probably expire." +
                    "\nWhat would you like to do?");
                if(!didLookUnderNews)
                {
                    Console.WriteLine("\n1. Read Newspaper");
                    
                }
                if(!didLookInMirror)
                {
                    Console.WriteLine("\n2. Check the mirror for good looks.");
                }
                if(!didCheckCloset)
                {
                    Console.WriteLine("\n3. Investigate snores.");
                }
                Console.WriteLine("\n4. Go outside.");
                Console.WriteLine("Enter the number of the choice you'd like to make");

                playerChoice = Console.ReadLine();

                switch(playerChoice)
                {
                    case "1":
                        if(didLookUnderNews)
                        {
                            Console.WriteLine("The newspaper was old and depricated. It is no more.");
                        }
                        else
                        {
                            Console.WriteLine("You check the newspaper, the front page reads: \"Fenrir devours another small Michigan town\"" +
                                "Where the newspaper was, you find an awesome mask!");
                            lil.ItemBag.Add(mask);
                            didLookUnderNews = true;
                        }
                        break;
                    case "2":
                        if(didLookInMirror)
                        {
                            Console.WriteLine("Yup, still freaking gorgeous");
                        }
                        else
                        {
                            Console.WriteLine("You look in the mirror, ignoring the backs under your eyes, you notice " +
                                "you slept with your sunglasses on your head again. Better pop those on your peepers.");
                            lil.ItemBag.Add(sunglasses);
                            didLookInMirror = true;

                        }
                        break;
                    case "3": 
                        if(didCheckCloset)
                        {
                            Console.WriteLine("Flufflze needs his damn rest.");
                        }
                        else
                        {
                            Console.WriteLine("The snores get only louder as you approach. You hesitate but slowly open the door" +
                                "\nto reveal your lil pet hampster \"Flufflez\", \"hey buddy!\" you say as you give him a couple of head scratches");
                            didCheckCloset = true;

                        }
                        break;
                    case "4":
                        bool response = true;
                        if(!didLookUnderNews && !didLookInMirror)
                        {
                            response = ConsoleStuff.YesOrNo("You are incredibly unprepared, do you still want to roll the dice? One wink from Odin and you'd be toast.");
                        }
                        else if(!didLookInMirror)
                        {
                            response = ConsoleStuff.YesOrNo("You didn't do your morning tick check, are you sure you would like to continue?");
                        }
                        else if(!didLookUnderNews)
                        {
                            response = ConsoleStuff.YesOrNo("That newspaper may be old but what if you missed a sweet Marmaduke comic, are you sure?");
                        }
                        else
                        {
                            Console.WriteLine("You look awesome, you feel awesome, time to head outside!");
                            break;
                        }

                        if(response)
                        {
                            Console.WriteLine("Odin's horse's sixth leg, I tried to warn you.\n The sunlight beams through the few thin layers of atmosphere that are left" +
                                " and burns out your eyes.\n You wander the wasteland as a blind beggar for the rest of your surprisingly not terrible days." +
                                "\nYeah you could have had pretty sweet adventure if you hadn't lost your vision, but Ol Lil Cleetus just turns the page...");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a number 1-4.");
                        break;
                }

                if(didLookUnderNews && didLookInMirror)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You have all the things you need for basic survival: Peeper cover, slop hole cover. " +
                        "\nTime to see if the unforgiving world has any forgiveness...");
                    ConsoleStuff.Break();
                    continue;
                }
            }

            return lil;
        }
    
}
