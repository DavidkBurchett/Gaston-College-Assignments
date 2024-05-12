using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Purpose:  find average highs of temperature from user entered amounts
// Author:   David Burchett
// Date:     3/13/2023
// Filename: DailyTemps.cs
// Input:    any amount of ints
// Output:   2 ints (average temps, total days)

namespace DailyTemps
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 0; //create variables
            int counter = -1;
            double averageTemp = 0;
            int sumOfTemps = 0;

            while (currentTemp != 999) //loop until user enters 999
            {
                if (currentTemp >= -20 && currentTemp <= 130) //make sure it is in valid range
                {

                    counter += 1;
                    sumOfTemps += currentTemp; //add to sum to prep for average

                    Console.Write("Enter a valid temp (-20 to 130, 999 to end): "); //user input
                    currentTemp = Convert.ToInt32(Console.ReadLine());

                }
                else //error handling
                {
                    Console.WriteLine("Enter a valid temperature.");
                    Console.Write("Enter a valid temp (-20 to 130, 999 to end): "); //user input
                    currentTemp = Convert.ToInt32(Console.ReadLine());
                }
            }

            averageTemp = (sumOfTemps + averageTemp) / counter;

            Console.WriteLine("The average temp is: " + averageTemp); //output
            Console.WriteLine("The total number of days is: " + counter);

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
