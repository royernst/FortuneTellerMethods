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
            Console.WriteLine("Who would cross the Bridge of Death");
            Console.WriteLine("Must answer me");
            Console.WriteLine("These questions three");
            Console.WriteLine("Ere the other side he see.");
            Console.WriteLine("What...is your first name?");
            firstName = Console.ReadLine().Trim();
            Console.WriteLine("...and your last name?");
            lastName = Console.ReadLine().Trim();
            Console.WriteLine("What...is your quest?");
            quest = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("What...is your favorite color? (ROYGBIV only please -- if you aren't sure what that is, type \"Help\".");
            favColor = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Right, off you go.");
            Console.WriteLine("Wait! Wait a moment!  Before leave, I could read your fortune if you'd like.  I just need a bit more information.");
            Console.WriteLine("Would you be interested? (YES/NO)");
            contResponse = Console.ReadLine().Trim().ToLower();



        }
    }
}
