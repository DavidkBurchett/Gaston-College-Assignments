using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  allow user to input test scores to compare against their average score
 * Author:   David Burchett
 * Date:     3/20/2023
 * Filename: TestScoreList.cs
 * Input:    8 ints representing test scores
 * Output:   return the 8 ints, an average ofg them, as well as a comparision between a score and the average
 */

namespace TestScoreList
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] testScores = new int[8]; //declare and initilize array and variables
            int scoreSum = 0;
            int counter = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter test score: ");
                int currentScore = Convert.ToInt32(Console.ReadLine()); //user input
                testScores[i] = currentScore; //populate array

                counter = i;
                scoreSum += currentScore; //store sum/counter for average
                
            }

            int average = scoreSum / counter;
            Console.WriteLine("The average is(rounded to nearest whole number): "+ average);

            foreach (var score in testScores) //print each element of the array
            {
                Console.WriteLine("The score is: " + score + " this is " + (score - average) + " compared to the average");
            }

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
