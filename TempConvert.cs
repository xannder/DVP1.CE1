using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class TempConvert
    {
        //NAME: Alexander Rodriguez
        //DATE: 1808
        //COURSE: Project & Porfolio 1
        //SYNOPSIS: Temperature degree converter: Fahrenheit to Celsius or vice-versa

        public static void ChTempConvert()
        {
            //Create variable for user choice and temp degree (Celcius / Fahrenheit)
            string strUserCh;
            int userChoice = 0;
            string tempDegree ="";
            char TD=' '; //Temperature Degree (First Letter only)
            char ITD = ' '; //Invert Temp Degree (First Letter only)
            string strUserTemp ="";
            double userTemp = 0;
            double tempResult = 0;
            
            Console.Clear();
            Console.WriteLine("TEMPCONVERT");
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            //Welcome user to the program
            Console.WriteLine("Welcome to Temperature Converted! Would you like to...");
            Console.WriteLine("");
            Console.WriteLine("1. Convert temperature form Fahrenheit to Celsius");
            Console.WriteLine("2. Convert temperaturee form Celsius to Fahrenheit");

            //Capture user choice
            strUserCh = Console.ReadLine();
            int.TryParse(strUserCh, out userChoice);

            //Validate user input is equal to 1 or 2
            while (userChoice < 1 || userChoice > 2)
            {
                //Notify user about the wrong input
                Console.WriteLine("You have entered a wrong input!");
                Console.Write("Please enter 1 for Fahrenheit to Celsius or 2 for Celsius to Fahrenheit:");

                //Re-capture user entry
                strUserCh = Console.ReadLine();
                int.TryParse(strUserCh, out userChoice);
            }

            //Identify temperature degree
            if (userChoice == 1)
            {
                tempDegree = "Fahrenheit";
                TD = 'F';
                ITD = 'C';
            }
            else
            {
                tempDegree = "Celsius";
                TD = 'C';
                ITD = 'F';
            }

            Console.WriteLine("");
            //Ask user which temperature (Fahrenheit / Celsius) he/she would like to convert
            Console.Write("Okay, what temprature in {0} would you like to convert? ",  tempDegree);

            //Capture user input (temperature)
            strUserTemp = Console.ReadLine();

            //Validate user temperature input - accept only numbers
            while (!double.TryParse(strUserTemp, out userTemp))
            {
                //Notify user about the wrong input
                Console.WriteLine("You have entered a wrong temperature!");
                Console.Write("Please enter the temperature in {0}: ",tempDegree);

                //Re-capture user entry
                strUserTemp = Console.ReadLine();
            }

            //Use custom function to calculate the temp convertion depending of the user choice
            if (userChoice == 1)
            {
                tempResult = GetCelsius(userTemp);
            }

            if (userChoice == 2)
            {
                tempResult = GetFahrenheit(userTemp);
            }
            
            //Show user the result
            Console.WriteLine("");
            Console.WriteLine("Excellent! {0}°{1} would be {2}°{3}", userTemp, TD, string.Format("{0:0}", tempResult), ITD);

            //Exit program and return to menu
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("Press any key to return to the main menu:");
            Console.ReadKey();
            Console.Clear();
            Menu.ChMenu();
        }


        //Custom Function to calculate the temp convertion Fahrenheit to Celsius
        public static double GetCelsius(double _userTemp)
        {
            double _GetUserTemp = _userTemp;
            double RetCelsius = ((_GetUserTemp - 32) * 5) / 9;
            return RetCelsius;
        }

        //Custom Function to calculate the temp convertion Fahrenheit to Celsius
        public static double GetFahrenheit(double _userTemp)
        {
            double _GetUserTemp = _userTemp;
            double RetFahrenheit = (_GetUserTemp * 1.8) + 32;
            return RetFahrenheit;
        }

    }
}
