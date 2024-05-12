using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveEstimator
{
    class MoveEstimator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of hours: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());

            double totalCost = (hours * 150) + (miles * 2) + 200;

            Console.Write("The total cost is $");
            Console.WriteLine(totalCost);
        }
    }
}
