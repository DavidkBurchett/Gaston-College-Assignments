using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  allows user to know how much it will ocst to paint a room with 9ft tall walls
 * Author:   David Burchett
 * Date:     4/3/2023
 * Filename: PaintingEstimate.cs
 * Input:    2 ints (length and width)
 * Output:   1 int (total cost)
 */

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the room: "); //user inputs
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the room: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The total cost is $" + priceCalculation(length, width)); //call and print method

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }

        static int priceCalculation(int length, int width)
        {
            return ((length * 9) * 2 + (width * 9) * 2) * 6; //formula to calcuate cost
        }
    }
}
