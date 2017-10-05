using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string quest;
            string userAge;
            string birthMonth;
            string favColor;
            string numSiblings;
            string contResponse;

            Console.WriteLine("STOP!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Who would cross the Bridge of Death");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Must answer me");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("These questions three");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ere the other side he see.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nWhat...is your first name?");
            firstName = Console.ReadLine().Trim();
            Console.WriteLine("\n...and your last name?");
            lastName = Console.ReadLine().Trim();
            Console.WriteLine("\nWhat...is your quest?");
            quest = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("\nWhat...is your favorite color?");
            Console.WriteLine("\nROYGBIV only please. If you aren't sure what that is, type \"Help\".");
            favColor = Console.ReadLine().Trim().ToLower();
            while (favColor == "help")
            {
                Console.WriteLine("Red\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n");
                Console.WriteLine("Now, what...is your favorite color?");
                favColor = Console.ReadLine().Trim().ToLower();
            }
            Console.WriteLine("\nRight, off you go.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\n\nWait! Wait a moment!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n\nBefore leave, I could read your fortune if you'd like.  I just need to ask you for three numbers.");
            Console.WriteLine("\nWould you be interested? (YES/NO)");
            contResponse = Console.ReadLine().Trim().ToLower();
            while (contResponse == "no")
            {
                Console.WriteLine("\nTerribly sorry.  That is not an option.");
                Console.WriteLine("I'll ask again.  WOULD you be interested?  (YES/NO)");
                contResponse = Console.ReadLine().Trim().ToLower();
            }
            Console.WriteLine("\nBrilliant!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nWhat...is your age?");
            userAge = Console.ReadLine().Trim();
            Console.WriteLine("\nWhat...is your birth month? (Month number only, please.)");
            birthMonth = Console.ReadLine().Trim();
            Console.WriteLine("\nWhat...is the number of siblings you have?");
            numSiblings = Console.ReadLine().Trim();
            Console.WriteLine("Just a moment, I'm beginning to see something...");
            Console.WriteLine("{0} {1} will retire in {3} years with {4} in the bank, a vacation home in {5} and a {6}.");
            Squid jerry = new Squid();
            Console.WriteLine(jerry.arms);
        }
    }
    
}
