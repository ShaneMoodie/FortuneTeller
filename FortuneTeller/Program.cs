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

            Console.WriteLine("Please press enter to begin.");

            Console.ReadKey();

            Console.WriteLine("Please tell me your first name.");
            string userFirst = Console.ReadLine();

            Console.WriteLine("Now please tell me your last name.");
            string userLast = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("In what numerical month were you born?");
            int userBMonth = int.Parse(Console.ReadLine());


            Console.WriteLine("What is your favorite ROYGBIV color? Enter \"Help\" for color repository.");
            string userColor = Console.ReadLine().ToLower();

            if (userColor == "help")
            {
                Console.WriteLine("Red \n Orange \n Yellow \n Green \n Blue \n Indigo \n Violet");

                Console.WriteLine("What is your favorite ROYGBIV color? Enter \"Help\" for color repository.");
                userColor = Console.ReadLine().ToLower();
            }
            else
            {
                Console.WriteLine("");
            }


            Console.WriteLine("How many sibilings do you have?");
            int userSib = int.Parse(Console.ReadLine());

            Console.WriteLine("\a" + "Computing fortune...this is totally accurate...press enter when ready.");

            Console.ReadKey();

            string retYear = "";

            if (userAge % 2 == 0)
            {
                retYear = "20 years";
            }
            else
            {
                retYear = "30 years";
            }


            string vacaHome = "";

            if (userSib == 0)
            {
                vacaHome = "The Citadel of Ricks";
            }
            else if (userSib == 1)
            {
                vacaHome = "Winterfell";
            }
            else if (userSib == 2)
            {
                vacaHome = "Rivendell";
            }
            else if (userSib == 3)
            {
                vacaHome = "Gotham City";
            }
            else if (userSib >= 4)
            {
                vacaHome = "Dr. Evil's Top Seceret Moon Base";
            }
            else if (userSib < 0)
            {
                vacaHome = "the dumpster behind Arby's";
            }


            string transport = "";

            if (userColor == "red")
            {
                transport = "a transportation gun";
            }
            else if (userColor == "orange")
            {
                transport = "a horse";
            }
            else if (userColor == "yellow")
            {
                transport = "a pogo stick";
            }
            else if (userColor == "green")
            {
                transport = "a Ford Model-T";
            }
            else if (userColor == "blue")
            {
                transport = "an old pair of Heelys";
            }
            else if (userColor == "indigo")
            {
                transport = "a skateboard missing one wheel";
            }
            else if (userColor == "violet")
            {
                transport = "a unicycle, complete with a dancing monkey wearing a hat";
            }


            string dollaBillz = "";

            if (userBMonth == 1 || userBMonth == 2 || userBMonth == 3 || userBMonth == 4)
            {
                dollaBillz = "$150,000";
            }
            else if (userBMonth == 5 || userBMonth == 6 || userBMonth == 7 || userBMonth == 8)
            {
                dollaBillz = "$500,000";
            }
            else if (userBMonth == 9 || userBMonth == 10 || userBMonth == 11 || userBMonth == 12)
            {
                dollaBillz = "$1,000,000";
            }
            else
            {
                dollaBillz = "$0.00";
            }

            Console.WriteLine(userFirst + " " + userLast + " will retire in " + retYear + " with " + dollaBillz + " in the bank, a vacation" + "\n" + "home in " + vacaHome + " and " + transport + ".");

        }
    }
}
