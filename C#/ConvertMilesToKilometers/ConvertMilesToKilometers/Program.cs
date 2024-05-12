using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  convert miles to kilometers
 * Author:   David Burchett
 * Date:     4/3/2023
 * Filename: ConvertMilesToKilometers.cs
 * Input:    1 double (miles)
 * Output:   1 double (kilometers)
 */

namespace ConvertMilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of miles: "); //user input
            double miles = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(miles + " miles converts to " + MilesToKilometers(miles) + " kilometers"); //call and output method

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }

        static double MilesToKilometers(double miles)
        {
            return miles * 1.60934; //calculation of miles to kilometers
        }
    }
}
