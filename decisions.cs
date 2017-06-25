using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway!");
            Console.Write("Choose A Door:  1 , 2, or 3: ");
            string uVal = Console.ReadLine();

            string message = "";

            if(uVal == "1")
            {
                 message = "You have won a New Car!";
            }

            else if(uVal == "2")
            {
                 message = "You have won a handjob from an asian hooker!  Wax-on!";
            }

            else if(uVal == "3")
            {
                 message = "You have won a stinky egg.  Bwa-Bwa-Bwa--Bwaaa...";
            }
            else
            {
                 message = "Sorry we didn't understand";
                 message += "You Lose.";
                
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }


    }
}
