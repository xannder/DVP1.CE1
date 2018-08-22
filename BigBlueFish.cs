using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class BigBlueFish
    {
        //NAME: Alexander Rodriguez
        //DATE: 1808
        //COURSE: Project & Porfolio 1
        //SYNOPSIS: Identify the biggest fish based on the color selection made by the user

        public static void ChBigBlueFish()
        {
            //Create variable for user input
            string strUserInput;
            int userInput = 0;
            string fishColor = "";
            float fishLen = 0;

            //Create array for colors
            string[] colors = new string[12] { "Green", "Green", "Yellow", "Blue", "Green", "Red", "Yellow", "Blue", "Red", "Yellow", "Blue", "Red" };

            //Create array for lenghts
            float[] lenghts = new float[12] { 6.2f, 14.5f, 8.0f, 3.7f, 13.5f, 18.3f, 21.0f, 5.6f, 23.9f, 22.9f, 12.4f, 7.8f };

            //Program Header
            Console.Clear();
            Console.WriteLine("BigBlueFish");
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            //Welcome user to Big Blue Fish
            Console.WriteLine("Welcome to Big Blue Fish:");
            Console.WriteLine("");
            Console.WriteLine("Looking for the biggest fish matching a certain color");

            //Show the Fish Color Menu and Ask user to enter a choice (1 to 4)
            Console.WriteLine("Please select a color of fish from the following option:");
            Console.WriteLine("");
            Console.WriteLine("[1] Red");
            Console.WriteLine("[2] Blue");
            Console.WriteLine("[3] Yellow");
            Console.WriteLine("[4] Green");
            Console.WriteLine("");
            Console.Write("Selection: ");

            //Capture user selection
            strUserInput = Console.ReadLine();
            int.TryParse(strUserInput, out userInput);

            //Validate User input (Only number from 1 to 4)
            while (userInput < 1 || userInput > 4)
            {
                //Notify user about wrong input
                Console.Write("Your selection is not valid! Please enter number from 1 to 4: ");

                //Re-capture user selection
                strUserInput = Console.ReadLine();
     
                int.TryParse(strUserInput, out userInput);
            }

            //Obtain user selection (fish color)
            switch (userInput)
            {
                case 1:
                    fishColor = "Red";
                    break;

                case 2:
                    fishColor = "Blue";
                    break;

                case 3:
                    fishColor = "Yellow";
                    break;

                case 4:
                    fishColor = "Green";
                    break;
            }

            //Determine the biggest fish according to the user's color selection
            for (int c = 0; c < colors.Length; c++)
            {
                if (colors[c] == fishColor)
                {
                    if (lenghts[c] > fishLen)
                    {
                        fishLen = lenghts[c];
                    }
                }
            }

            //Show result to user
            Console.WriteLine("");
            Console.WriteLine("Woa! Looks like the biggest {0} fish is {1} inches.",fishColor, fishLen);

            //Exit program and return to menu
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("Press any key to return to the main menu:");
            Console.ReadKey();
            Console.Clear();
            Menu.ChMenu();
        }
    }
}
