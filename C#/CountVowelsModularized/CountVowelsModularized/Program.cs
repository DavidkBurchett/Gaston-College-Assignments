using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  count the amount of vowels in a string
 * Author:   David Burchett
 * Date:     4/3/2023
 * Filename: CountVowelsModularized.cs
 * Input:    1 string
 * Output:   1 int 
 */

namespace CountVowelsModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a phrase: "); //user inputs
            string input = Console.ReadLine();

            Console.WriteLine("the phrase has " + VowelCount(input) + " vowels"); //calls and prints method

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }

        static int VowelCount(string input)
        {
            int vowelCount = 0;
            int i;
            int len = input.Length;
            for (i = 0; i < len; i++) //for counting the vowels in the string
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    vowelCount++;
                }
            }
                return vowelCount; //return
        }
    }
}
