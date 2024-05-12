using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class MakeChange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dollar amount: $");
            int dollars = Convert.ToInt32(Console.ReadLine());

            int twenties = dollars / 20;
            int tens = (dollars % 20) / 10;
            int fives = (dollars % 10) / 5;
            int ones = (dollars % 5) / 1;

            Console.Write("$");
            Console.Write(dollars);
            Console.Write(" is ");
            Console.Write(twenties);
            Console.Write(" twenties ");
            Console.Write(tens);
            Console.Write(" tens ");
            Console.Write(fives);
            Console.Write(" fives ");
            Console.Write(ones);
            Console.WriteLine(" ones ");
        }
    }
}
