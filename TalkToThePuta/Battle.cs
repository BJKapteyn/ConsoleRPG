using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    class Battle
    {
        //for regular blow for blow battles
        public static void RegularFight(LilCleetus lilCleet, IAdversary bloke)
        {
            Console.WriteLine($"You've been confronted with {bloke.Name}, they don't look friendly");
            bool isRunning = true;

            while(isRunning)
            {
                Console.WriteLine($"You have {lilCleet.Health} health");
                Console.WriteLine("What would you like to do?\n" +
                    "\n1. Attack that sucka" +
                    "\n2. Let's get out of here (run)");

                string response = Console.ReadLine();

                int yourDamage = 0;
                int theirDamage = 0;

                if(response == "1")
                {
                    //damage is calculated here for 
                    yourDamage = lilCleet.Attack();
                    theirDamage = bloke.Attack();
                }
                else if(response == "2")
                {
                    //you get a %50 chance to run.
                    Random r = new Random();
                    int flipACoin = r.Next(1, 3);
                    if (flipACoin == 2)
                    {
                        Console.WriteLine("If you want to run so much, learn to run.");
                        yourDamage = 0;
                        theirDamage = bloke.Attack();
                    }
                    else
                    {
                        Console.WriteLine("You got away!");
                        isRunning = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number 1 or 2 please thaaaaaanks.");
                    Console.ReadKey();
                }

                Console.WriteLine($"You did {yourDamage.ToString()}\n" +
                    $"{bloke.Name} did {theirDamage.ToString()}");
                //take any damage away.
                lilCleet.Health -= theirDamage;
                bloke.Health -= yourDamage;

                if(lilCleet.Health <= 0 || bloke.Health <= 0)
                {
                    if(lilCleet.Health <= 0)
                    {
                        Console.WriteLine("Dang it ya died!");
                    }
                    else
                    {
                        Console.WriteLine($"{bloke.Name} fell to his knees, staring longingly at the setting sun and dies peacefully");
                    }
                    isRunning = false;
                    break;
                }

                ConsoleStuff.Break();
            }


        }

    }
}
