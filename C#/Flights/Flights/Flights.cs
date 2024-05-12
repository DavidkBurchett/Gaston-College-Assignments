using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Purpose:  find flight infro with flight number or airport code
 * Author:   David Burchett
 * Date:     4/17/2023
 * Filename: Flights.cs
 * Input:    string or int
 * Output:   flight info
 */

namespace Flights
{
    class Flights
    {
        static void Main(string[] args)
        {
            int flightNumber = 0;

            Console.Write("Enter flight number/airport code: "); //user inputs
            string airportCode = Console.ReadLine();

            try
            {
                flightNumber = Convert.ToInt32(airportCode); //converts to int, ignores if it cant
            }
            catch (Exception e)
            {
                flightNumber = 0;
            }

            if (flightNumber != 0) //passes an int if avaible, passes string if not
            {
                Console.WriteLine(GetFlightInfo(flightNumber));
            }
            else
            {
                Console.WriteLine(GetFlightInfo(airportCode));
            }
            


            Console.WriteLine("Press enter to close this window"); //prevents program from closing instantly
            Console.ReadLine();
        }

        static string GetFlightInfo(int flightNumber) //method with int
        {
            switch (flightNumber)
            {
                case 201:
                    return "Airport code - AUS | Airport name - Austin | Time - 0710" ;

                case 321:
                    return "Airport code - CRP | Airport name - Corpus Christi | Time - 0830";

                case 510:
                    return "Airport code - DFW | Airport name - Dallas Fort Worth | Time - 0915";

                case 633:
                    return "Airport code - HOU | Airport name - Houston | Time - 1140";

                default:
                    return "Enter a vaild Flight number/Airport code";

            }
        }

        static string GetFlightInfo(string airportCode) //method overloaded with string
        {
            switch (airportCode)
            {
                case "AUS":
                    return "Flight number - 201 | Airport name - Austin | Time - 0710";

                case "CRP":
                    return "Flight number - 321 | Airport name - Corpus Christi | Time - 0830";

                case "DFW":
                    return "Flight number - 510 | Airport name - Dallas Fort Worth | Time - 0915";

                case "HOU":
                    return "Flight number - 633 | Airport name - Houston | Time - 1140";

                default:
                    return "Enter a vaild Flight number/Airport code";

            }
        }
    }
}
