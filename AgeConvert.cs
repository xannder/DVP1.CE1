using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1.CE1
{
    class AgeConvert
    {

        //NAME: Alexander Rodriguez
        //DATE: 1808
        //COURSE: Project & Porfolio 1
        //SYNOPSIS: Ask user to enter his/her name and age, then calculate the age into days, hours, minutes and seconds.

        public static void ChAgeConvert()
        {
            //Create variables for name and age
            string userName;
            string strUserAge;
            int userAge = 0;
            int ageDays = 0;
            long ageHours = 0;
            long ageMins = 0;
            long ageSecs = 0;

            Console.Clear();
            Console.WriteLine("AGE CONVERTER");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("");

            Console.WriteLine("Welcome to Age Converter!");
            Console.WriteLine("");

            //Aks user to enter his/her name
            Console.WriteLine("Please enter your name:");

            //Store user name
            userName = Console.ReadLine();

            //Validate the user name is not null
            while (string.IsNullOrWhiteSpace(userName))
            {
                //Notify user about the null value (name)
                Console.WriteLine("Your entry is null! Please enter your name:");

                //Capture the user name
                userName = Console.ReadLine();
                Console.WriteLine("");
            }

            //Ask user for his/her age
            Console.WriteLine("");
            Console.WriteLine("Thank you {0}. Now I know this may be personal, but what's your age?",userName);

            //Store user age
            strUserAge = Console.ReadLine();

            //Validate that user entry (number only)

            while(!int.TryParse(strUserAge, out userAge)){
                //Notify the user about the wrong entry
                Console.WriteLine("The entry is not correct. Please provide your age:");

                //Read user input
                strUserAge = Console.ReadLine();
            }

            //Calculate the age: days, hours, minutes and seconds
            ageDays = TotalDays(userAge);
            ageHours = TotalHours(userAge);
            ageMins = TotalMinutes(userAge);
            ageSecs = TotalSeconds(userAge);

            //Show the age and give some idea about possible answers
            Console.WriteLine("");
            Console.WriteLine("Great! Your age is {0}. Next time someone asks, try answering something like this:", userAge);
            Console.WriteLine("{0} days -or-", string.Format("{0:n0}", ageDays));
            Console.WriteLine("{0} hours -or-", string.Format("{0:n0}",ageHours));
            Console.WriteLine("{0} minutes-or-", string.Format("{0:n0}", ageMins));
            Console.WriteLine(string.Format("{0:n0}", ageSecs) + " seconds");

            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("Press any key to return to the main menu:");
            Console.ReadKey();
            Console.Clear();
            Menu.ChMenu();
        }

        //Custom Function to return user age in days
        public static int TotalDays(int _UserAge)
        {
            int _GetUserAge = _UserAge;
            int _totDaysAge = _GetUserAge * 365;

            return _totDaysAge;
        }

        //Custom Function to return user age in hours
        public static long TotalHours(int hUserAge)
        {
            int _hUserAge = hUserAge;
            long getAgeHours = (_hUserAge * 365) * 24;

            return getAgeHours;
        }

        //Custom Function to return user age in minutes
        public static long TotalMinutes(int mUserAge)
        {
            int _mUserAge = mUserAge;
            long getAgeMins = ((_mUserAge * 365) * 24) * 60;

            return getAgeMins;
        }

        //Custom Function to return user age in seconds
        public static long TotalSeconds(int sUserAge)
        {
            int _sUserAge = sUserAge;
            long getAgeSecs = (((_sUserAge * 365) * 24) * 60)*60;

            return getAgeSecs;
        }
    }
}
