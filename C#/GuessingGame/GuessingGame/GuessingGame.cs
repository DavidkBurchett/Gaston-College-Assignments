using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Purpose:  make the user guess a randomly generated number
// Author:   David Burchett
// Date:     2/19/2023
// Filename: GuessingGame.cs
// Input:    a number guess
// Output:   wether the user was correct, too high, or too low

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int hiddenNumber = ranNumberGenerator.Next(1, 11); //generate the hidden number
            //Console.WriteLine(hiddenNumber); //for testing

            Console.Write("Enter your guess (1-10): ");
            int userGuess = Convert.ToInt32(Console.ReadLine()); //User input

            if (hiddenNumber > userGuess) //user guess too low
            {
                Console.Write("You were too low! the number was - ");
                Console.WriteLine(hiddenNumber);
            }
            else if (hiddenNumber < userGuess) //user guesses too high
            {
                Console.Write("You were too high! the number was - ");
                Console.WriteLine(hiddenNumber);
            }
            else //user guesses correctly 
            {
                Console.Write("Good Job! you got it! the correct number was - ");
                Console.WriteLine(hiddenNumber);
            }

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
