using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSquareRoot
{
    class FindSquareRoot
    {
        static void Main(string[] args)
        {
            double userInput, square = 0;
            Write("Enter a number ");
          
            try
            {
                userInput = Convert.ToDouble(ReadLine());
                square = Math.Sqrt(userInput);
                if (userInput < 0)
                {
                    throw new squareException();
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                square = 0;
            }
            finally
            {
                WriteLine("Square root is " + square);
                ReadLine();
            }
        }
    }

    class squareException : Exception
    {
        private static string msg = "Error: Number can't be negative.";
        public squareException() : base(msg) { }
    }
}
