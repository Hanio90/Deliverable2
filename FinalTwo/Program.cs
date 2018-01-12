using System;

namespace FinalTwo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // declaring values
            DateTime date1;
            DateTime date2;
            TimeSpan timeDiff;
            int dayDiff;
            int hourDiff;
            int minuteDiff;

            // String is written into the console and asks the user to input the following data in a certain order
            Console.WriteLine("Please enter your first date. In the following format: MM/DD/YYYY HH:MM:SS");
            date1 = DateTime.Parse(Console.ReadLine());

            // String is written into the console and asks the user to input the secondary data in a certain order
            Console.WriteLine("Please enter your second date. In the following format: MM/DD/YYYY HH:MM:SS");
            date2 = DateTime.Parse(Console.ReadLine());

            // CompareTo method returns a positive integer if the first date is later than the second date
            if(date1.CompareTo(date2) > 0)
            {
                timeDiff = date1.Subtract(date2);
            }
            else if (date1.CompareTo(date2) < 0)
            {
                timeDiff = date2.Subtract(date1);
            }
            else
            {
                Console.WriteLine("The dates are equal");
            }

            // Assigning the different values of the Time Difference.
            hourDiff = timeDiff.Hours;
            dayDiff = timeDiff.Days;
            minuteDiff = timeDiff.Minutes;

            Console.WriteLine($"Days: " + dayDiff + " Hours: " + hourDiff + " Minutes: " + minuteDiff);

        }

    }

  
}


