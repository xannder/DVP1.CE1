using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class SwapName
    {
        //NAME: Alexander Rodriguez
        //DATE: 1808
        //COURSE: Project & Porfolio 1
        //SYNOPSIS: Obtain user first name and last name and swap the username (last name, first name)

        /*
        public string firstNam;
        public string lastNam;

        public SwapName(string firstNam, string lastNam)
        {
            this.firstNam = firstNam;
            this.lastNam = lastNam;
        }
        */
        
        public static void ChSwapName()
        {
            //Create Variable for Swap Name
            string firstNam;
            string lastNam;

            //Clear Console and Welcome user to Swap Name
            Console.Clear();
            Console.WriteLine("SWAPNAME");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            Console.WriteLine("Welcome to Swap Name!");
            Console.WriteLine("");

            //Ask user to enter firstname
            Console.WriteLine("Please enter your first name:");
            firstNam = Console.ReadLine();
            Console.WriteLine("");

            //Validate the user firstname is not null
            while(string.IsNullOrWhiteSpace(firstNam))
            {
                //Notify user about the null value (firstname)
                Console.WriteLine("Your entry is null! Please enter your first name:");

                //Capture the user first name
                firstNam = Console.ReadLine();
                Console.WriteLine("");
            }

            //Ask user to enter last name
            Console.WriteLine("Thank you {0}, please enter your last name:", firstNam);
            lastNam = Console.ReadLine();

            //Validate the user lastname is not null
            while (string.IsNullOrWhiteSpace(lastNam))
            {
                //Notify user about the null value (lastname)
                Console.WriteLine("Your entry is null! Please enter your lastname:");

                //Capture the user first name
                lastNam = Console.ReadLine();
                Console.WriteLine("");
            }

            //Show the result
            Console.WriteLine("Excellent! Your name ({0} {1}), reversed name would be {1}, {0}", firstNam, lastNam);

            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("Press any key to return to the main menu:");

            //Clear Console and return to Menu
            Console.ReadKey();
            Console.Clear();
            Menu.ChMenu();
        }
    }
}
