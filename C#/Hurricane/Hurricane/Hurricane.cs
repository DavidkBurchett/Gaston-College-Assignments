using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Purpose:  determine the category of a hurricane based on user input wind speed
// Author:   David Burchett
// Date:     2/19/2023
// Filename: Hurricane.cs
// Input:    Wind speed
// Output:   Hurricane category level

namespace Hurricane
{
    class Hurricane
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the wind speed: ");
            int windSpeed = Convert.ToInt32(Console.ReadLine()); //User input

            if (windSpeed >= 157) //check for category 5
            {
                Console.WriteLine("Category 5");
            }
            else if (windSpeed >= 130) //check for category 4
            {
                Console.WriteLine("Category 4");
            }
            else if (windSpeed >= 111) //check for category 3
            {
                Console.WriteLine("Category 3");
            }
            else if (windSpeed >= 96) //check for category 2
            {
                Console.WriteLine("Category 2");
            }
            else if (windSpeed >= 74) //check for category 1
            {
                Console.WriteLine("Category 1");
            }
            else //check for failure condition, which is not a hurricane
            {
                Console.WriteLine("Not a hurricane");
            }

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
