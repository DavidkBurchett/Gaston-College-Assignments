using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptExceptionTest
{
    class SubscriptExceptionTest
    {
        static void Main()
        {
            int userInput = 0;
            double[] array = {20.3, 44.6, 32.5, 46.7, 89.6,
                        67.5, 12.3, 14.6, 22.1, 13.6};

            try
            {
                while (true)
                {
                    WriteLine("Enter subscript: ");
                    userInput = Convert.ToInt32(ReadLine());

                    if(userInput == 99)
                    {
                        break;
                    }

                    WriteLine("Subscript value = " + array[userInput]);
                }
            }catch(IndexOutOfRangeException)
            {
                WriteLine("Index was outside the bounds of the array.");
            }
        }
    }
}
