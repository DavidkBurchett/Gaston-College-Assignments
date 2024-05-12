using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    public class Auction
    {
        static void Main()
        {
            int min = 10;

            Console.WriteLine("Enter Bid (must be at least $10):");
            var bid = Console.ReadLine();

            AcceptBid(bid, min);

            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }

        public static void AcceptBid(int bid, int min)
        {
            if(bid >= min)
            {
                Console.WriteLine("Bid accepted.");
            }
            else
            {
                Console.WriteLine("Bid not high enough.");
            }
        }
        public static void AcceptBid(double bid, int min)
        {
            if (bid >= min)
            {
                Console.WriteLine("Bid accepted.");
            }
            else
            {
                Console.WriteLine("Bid not high enough.");
            }
        }
        public static void AcceptBid(string bid, int min)
        {
            try
            {
                int num = Convert.ToInt32(string.Concat(bid.Where(Char.IsDigit)));

                if (num >= min)
                {
                    Console.WriteLine("Bid accepted.");
                }
                else
                {
                    Console.WriteLine("Bid not high enough.");
                }
            }
            catch
            {
                Console.WriteLine("Bid was not in correct format.");
            }
        }

    }
}
