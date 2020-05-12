using System;
using System.Collections.Generic;
using System.Text;

namespace TalkToThePuta
{
    class ConsoleStuff
    {
        public static void Break()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool YesOrNo(string question)
        {
            Console.WriteLine(question);
            Console.Write(" (Y/N)");
            string response = Console.ReadLine()
                                     .ToUpper();

            switch(response)
            {
                case "Y":
                    return true;
                case "N":
                    return false;
                default:
                    Console.WriteLine("Please enter Y or N");
                    YesOrNo(question);
                    break;
            }
            return false;
        }
    }
}
