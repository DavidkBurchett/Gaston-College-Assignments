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

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //the array

            Console.WriteLine("Enter a number to select an option"); //user selction options
            Console.WriteLine("1 - view list in ascending order");
            Console.WriteLine("2 - view list in descending order");
            Console.WriteLine("3 - view a specific postion");
            Console.WriteLine("4 - quit");
            int selection = Convert.ToInt32(Console.ReadLine());

            while (selection != 4)
            {

                switch (selection)
                {
                    case 1: //ascending
                        foreach (var item in numArray) //print each element of the array
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 2: //descending
                        Array.Reverse(numArray);
                        foreach (var item in numArray) //print each element of the array
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        Array.Reverse(numArray);
                        break;

                    case 3: //specific position
                        Console.Write("Enter the specific position you want (0-9): ");
                        int arrayPosition = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(numArray[arrayPosition]);
                        break;

                    default: //invalid number
                        Console.Write("Enter a valid selection (1-4): ");
                        break;

                }

                Console.Write("Enter a number to select an option (1-4): ");
                selection = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
