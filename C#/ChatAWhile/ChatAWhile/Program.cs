using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  Allow user to select option to view an array
 * Author:   David Burchett
 * Date:     3/20/2023
 * Filename: ArrayDemo.cs
 * Input:    1 int
 * Output:   different array views
 */

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            double[ , ] priceByAreaCodeArray = {{262, 414, 608, 715, 815, 920}, //create array
                                      {.07, .10, .05, .16, .24, .14 } };

            for (int i = 0; i < priceByAreaCodeArray.GetLength(0); i++) //print array
            {
                for (int j = 0; j < priceByAreaCodeArray.GetLength(1); j++)
                {
                    Console.WriteLine(priceByAreaCodeArray[i, j]);
                }
            }

            Console.Write("Enter the area code: "); //user inputs
            int areaCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of hours: ");
            double hours = Convert.ToInt32(Console.ReadLine()); 
            double totalPrice = 0;

            switch (areaCode) //for different area codes
            {
                case 262:
                    totalPrice = hours * priceByAreaCodeArray[1, 0];
                    break;

                case 414:
                    totalPrice = hours * priceByAreaCodeArray[1, 1];
                    break;

                case 608:
                    totalPrice = hours * priceByAreaCodeArray[1, 2];
                    break;

                case 715:
                    totalPrice = hours * priceByAreaCodeArray[1, 3];
                    break;

                case 815:
                    totalPrice = hours * priceByAreaCodeArray[1, 4];
                    break;

                case 920:
                    totalPrice = hours * priceByAreaCodeArray[1, 5];
                    break;
            }
            Console.WriteLine("The total cost is: " + totalPrice); //output

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
