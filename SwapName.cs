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
        //SYNOPSIS:

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
            Console.WriteLine("Welcome to SwapName!"); 
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            //Ask user to enter first name
            Console.WriteLine("Please enter your first name:");
            firstNam = Console.ReadLine();

            //Ask user to enter last name
            Console.WriteLine("Thank you {0}, please enter your last name:", firstNam);
            lastNam = Console.ReadLine();

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
