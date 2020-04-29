using System;

namespace TalkToThePuta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this place, Lil Cleetus \nLet's Customize your Cleet");

            int pointsToSpend = 10;

            int mass = 5;
            int intellignece = 5;
            int attitude = 5;
            int health = 10;

            string sMass = mass.ToString();
            string sIntell = intellignece.ToString();
            string sAttitude = attitude.ToString();
            string sHealth = health.ToString();
            string sPoints = pointsToSpend.ToString();

            Console.WriteLine("\nHere are your stats:\n\n" +
                                $"1.     Mass:         {sMass}\n" +
                                $"2.     Intelligence: {sIntell}\n" +
                                $"3.     Attitude:     {sAttitude}\n" +
                                $"4.     Health:       {sHealth}\n");

            Console.WriteLine($"/nYou have {sPoints} good boy points\n Enter the number of good boy points you want to goop your mass stat up.");

            while(true)
            {
                Console.WriteLine($"Enter a number 1 to {sPoints}");
                string sAnswer = Console.ReadLine();

                int pointsToAdd = 0;

                bool isNumber = int.TryParse(sAnswer, out pointsToAdd);

                if (isNumber)
                {
                    if(pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
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

            while(true)
            {
                Console.WriteLine("How many points do you want to spend on intelligence");
                string sInt = Console.ReadLine();

                int pointsToAdd = 0;
                bool isNumber = int.TryParse(sInt, out pointsToAdd);

                if(isNumber == true)
                {
                    if(pointsToAdd >= 0 && pointsToAdd <= pointsToSpend)
                    {
                        intellignece += pointsToAdd;
                        pointsToSpend -= pointsToAdd;
                        sIntell = intellignece.ToString();
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

            Console.ReadKey();


          






























            //while(true)
            //{
            //    string answer = "";
            //    Console.WriteLine("How many gorillas do you rule over?");
            //    answer = Console.ReadLine();

            //    int num = 0;

            //    bool isNumber = int.TryParse(answer, out num);

            //    if(isNumber)
            //    {
            //        Console.WriteLine($"{answer}? Friggin Dope!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{answer} isn't a number ya boof");
            //    }
            //}

            //bool keepGoing = true;
            //while(keepGoing)
            //{
            //    Console.WriteLine("What's the color of your back?");
            //    string answer = Console.ReadLine();
            //    answer = answer.ToLower();

            //    switch(answer)
            //    {
            //        case "silver":
            //            Console.WriteLine("awesome!");
            //            break;
            //        case "brown":
            //            Console.WriteLine("You're a soft Normie");
            //            break;
            //        case "black":
            //            Console.WriteLine("That's dumb and you should feel bad.");
            //            break;
            //        case "blue":
            //            Console.WriteLine("Blue is alright I guess, Silver is the best though.");
            //            break;
            //        case "Gorblundszk":
            //            Console.WriteLine("That's dope!");
            //            break;
            //        default:
            //            Console.WriteLine("You suck Please enter a better color");
            //            continue;
            //    }
            //    keepGoing = false;
            //}
        }

    }
}
