using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Purpose:  find total of ints entered by user
// Author:   David Burchett
// Date:     3/13/2023
// Filename: Hurricane.cs
// Input:    any amount of ints
// Output:   1 int total

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentInt = 0; //creates variables that will store the user input and sum
            int totalSum = 0;

            while (currentInt != 999)
            {

                totalSum += currentInt; //add input to sum

                Console.Write("Enter the next Int: ");
                currentInt = Convert.ToInt32(Console.ReadLine()); //get input

            }

            Console.WriteLine("The total is: " + totalSum); //output

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
