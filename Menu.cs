using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class Menu
    {
        //NAME: Alexander Rodriguez
        //DATE: 1808
        //COURSE: Project & Porfolio 1
        //SYNOPSIS: Menu that allows the user to select an option to run programs from the coding challenges

        //Create fucntion for Menu

        public static void ChMenu()
        {

            //Variable for user selection
            string strUserSel;
            int userSel = 0;
            bool valOpt = false;

            //Welcome and header
            Console.WriteLine("");
            Console.WriteLine("Welcome to my Project Porfolio Coding Challenge");
            Console.WriteLine("");

            Console.WriteLine("PROJECT + PORFOLIO");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            //Show user menu
            Console.WriteLine("Coding Challenge Menu: \r\nPlease enter the number for the challenge you want to run...");
            Console.WriteLine("");

            Console.WriteLine("[1] Swap Name");
            Console.WriteLine("[2] Backwards");
            Console.WriteLine("[3] Age Convert");
            Console.WriteLine("[4] Temp Convert");
            Console.WriteLine("[5] Big Blue Fish");
            Console.WriteLine("");

            Console.WriteLine("[0] Exit");
            Console.WriteLine("");

            Console.WriteLine("********************************************");

            //Ask user to enter a selection
            Console.WriteLine("Make your selection:");
            strUserSel = Console.ReadLine();

            //Valitate user selection (number only)
            while (!int.TryParse(strUserSel, out userSel))
            {
                Console.WriteLine("Your have enter a invalid selection!\r\nPlease enter a valid selection from 1 - 5:");
                //Read user option
                strUserSel = Console.ReadLine();
            }

            //Valitate user selection (0 - 5)
            if (userSel > 5)
            {
                valOpt = false;
            }
            else
            {
                valOpt = true;
            }

            while (valOpt != true)
            {
                Console.WriteLine("Your selection is not valid!\r\nPlease enter a valid selection from 1 - 5:");
                //Read user option
                strUserSel = Console.ReadLine();
                int.TryParse(strUserSel, out userSel);

                if (userSel > 5)
                {
                    valOpt = false;
                }
                else
                {
                    valOpt = true;
                }

            }

            //Run Menu option depending on user selection

            //If selection is equal to 1 then run SwapName
            if (userSel == 1) { 
                SwapName.ChSwapName();
            }

            //If selection is equal to 2 then run Backwards
            if (userSel == 2)
            {
                Backwards.ChBackwards();
            }

            //If selection is equal to 3 then run Age Convert
            if (userSel == 3)
            {
                AgeConvert.ChAgeConvert();
            }

            //If selection is equal to 4 then run TempConvert
            if (userSel == 4)
            {
                TempConvert.ChTempConvert();
            }

            //If selection is equal to 5 then run BigBlueFish
            if (userSel == 5)
            {
                BigBlueFish.ChBigBlueFish();
            }

            //If selection is equal to 0 then return to Menu
            if (userSel == 0)
            {
                Environment.Exit(0);
            }

        }
    }
}
