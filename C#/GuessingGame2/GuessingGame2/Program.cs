using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Purpose:  make the user guess a randomly generated number, edited to allow multiple tries
// Author:   David Burchett
// Date:     2/19/2023 (edited - 3/13/2023)
// Filename: GuessingGame.cs
// Input:    a number guess
// Output:   wether the user was correct, too high, or too low

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess = 0;
            int count = 0;

            Random ranNumberGenerator = new Random();
            int hiddenNumber = ranNumberGenerator.Next(1, 11); //generate the hidden number
            //Console.WriteLine(hiddenNumber); //for testing

            while (hiddenNumber != userGuess)
            {

                count += 1;

                Console.Write("Enter your guess (1-10): ");
                userGuess = Convert.ToInt32(Console.ReadLine()); //User input

                if (hiddenNumber > userGuess) //user guess too low
                {
                    Console.WriteLine("You were too low!");
                }
                else if (hiddenNumber < userGuess) //user guesses too high
                {
                    Console.WriteLine("You were too high!");
                }
                else //user guesses correctly 
                {
                    Console.WriteLine("Good Job! you got it! the correct number was - " + hiddenNumber);
                    Console.WriteLine("It took you " + count + " guesses");
                    
                }
            }

            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }
    }
}
