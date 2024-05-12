using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static System.Console;
using System.Globalization;

namespace DebugNine2
{
    class DebugNine2
    {
        static void Main()
        {
            Breakfast special = new Breakfast("French toast", 4.99);
            //Display the info about breakfast
            WriteLine(Breakfast.INFO);
            // then display today's special
            WriteLine("Today we are having {0} for {1}",
               special.Name, special.Price.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
        }
    }
    class Breakfast
    {
        public static string INFO =
           "Breakfast is the most important meal of the day.";

        // Breakfast constructor requires a
        // name, e.g "French toast", and a price
        public Breakfast(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

}
