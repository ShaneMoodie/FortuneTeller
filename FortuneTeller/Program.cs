using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the mystical fortune telling fortune teller!");

            Console.WriteLine("Please tell me your first name.");
            string userFirst = Console.ReadLine();

            Console.WriteLine("Now please tell me your last name.");
            string userLast = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("In what numerical month were you born?");
            int userBMonth = int.Parse(Console.ReadLine());

            if (userBMonth == 1 || userBMonth == 2 || userBMonth == 3 || userBMonth == 4)
            {
                Console.WriteLine("$150,000");
            }
            else if (userBMonth == 5 || userBMonth == 6|| userBMonth == 7 || userBMonth == 8)
            {
                Console.WriteLine("$500,000");
            }
            else if (userBMonth == 9 || userBMonth == 10 || userBMonth == 11 || userBMonth == 12)
            {
                Console.WriteLine("$1,000,000 (Mwah-ha-ha!!!)");
            }
            else
            {
                Console.WriteLine("$0.00");
            }

            Console.WriteLine("What is your favorite ROYGBIV color? Enter \"HELP\" for color repository.");
            string userColor = Console.ReadLine();

            Console.WriteLine("How many sibilings do you have?");
            int userSib = int.Parse(Console.ReadLine());

            Console.WriteLine("Computing fortune...this is totally accurate...press enter when ready.");

            //Console.WriteLine(userFirst + userLast "will retire in"


        }
    }
}
