using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  change order of 3 ints
 * Author:   David Burchett
 * Date:     4/17/2023
 * Filename: Reverse3.cs
 * Input:    3 ints
 * Output:   3 ints
 */

namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 2; //declare ints
            int middleInt = 4;
            int lastInt = 6;

            Console.WriteLine(firstInt + " " + middleInt + " " + lastInt); //first print

            SwitchValues(ref firstInt, ref middleInt, ref lastInt); //pass as refs

            Console.WriteLine(firstInt + " " + middleInt + " " + lastInt); //second print

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }

        static void SwitchValues(ref int first, ref int middle, ref int last) //swap positions 
        {
            int tempInt = first; 
            first = last;
            last = tempInt;
        }
    }
}
