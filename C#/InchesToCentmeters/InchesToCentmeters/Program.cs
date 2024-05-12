using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentmetersInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CentimetersInInch = 2.54;

            Console.WriteLine("Enter the amount of Inches");
            double inches = Convert.ToDouble(Console.ReadLine());


            double centimeters = inches * CentimetersInInch;

            Console.Write(inches);
            Console.Write(" inches is ");
            Console.Write(centimeters);
            Console.WriteLine(" centimeters.");
        }
    }
}
