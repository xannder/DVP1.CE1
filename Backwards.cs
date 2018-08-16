using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class Backwards
    {
        //NAME: Alexander Rodriguez
        //DATE: 1808
        //COURSE: Project & Porfolio 1
        //SYNOPSIS:

        public static void ChBackwards()
        {
            //Create variables for Backwards
            string userSentence;
            string bwUserSentence = "";
            int sentLen = 0;

            //Welcome user to Backwards
            //Console.WriteLine("BACKWARDS");
            Console.Clear();
            Console.WriteLine("Welcome to Backwards:");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            
            Console.WriteLine("Please enter a sentece containing at least 6 words:");

            //Capture user sentence
            userSentence = Console.ReadLine();

            //Print out the user sentence
            Console.WriteLine("");
            Console.WriteLine("Thank you! You entered the sentence:\r\n{0}", userSentence);

            //Backward user sentence and store in bwUserSentence
            //User sentence lenght
            sentLen = userSentence.Length;

            //Revers user sentence
            for (int i = sentLen - 1; i >= 0; i--)
            { 
                bwUserSentence =  bwUserSentence + Convert.ToString(userSentence[i]);
            }
            //Print out the backward sentence
            Console.WriteLine("");
            Console.WriteLine("Backward this sentece would read:\r\n{0}", bwUserSentence);
            Console.WriteLine("");

            //Wait for user press any key and then clear console and return to Menu
            Console.WriteLine("********************************************");
            Console.WriteLine("Press any key to return to the main menu:");
            Console.ReadKey();
            Console.Clear();
            Menu.ChMenu();

           

        }






    }
}
