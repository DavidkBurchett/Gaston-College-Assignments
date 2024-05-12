using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class IntegerFacts
    {
        static void Main()
        {
            int[] numberArray = new int[10];

            Console.WriteLine("Enter 10 numbers for array, or 999 to stop");

            Statistics(FillArray(numberArray), out int sizeOfArray, out int highestNum, out int lowestNum, out int sumOfArray, out double averageOfArray);

            Console.WriteLine("The array has " + sizeOfArray + " values \n" +
                "The highest value is " + highestNum + "\n" +
                "The lowest value is " + lowestNum + "\n" +
                "The sum of the values is " + sumOfArray + "\n" +
                "The average is " + averageOfArray);

            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }

        public static int[] FillArray(int[] array)
        {
            int currentNumber = 0;
            int counter = 0;

            while (counter != 10 && currentNumber != 999)
            {
                try
                {
                    Console.WriteLine("Enter the next number:");
                    currentNumber = Convert.ToInt32(Console.ReadLine());
                    if(currentNumber != 999)
                    {
                        array[counter] = currentNumber;
                        counter += 1;
                    }   
                }
                catch
                {
                    Console.WriteLine("Enter a valid number. \n");
                }
            }

            return array;
        }
        public static void Statistics(int[] array, out int els, out int high, out int low, out int sum, out double avg)
        {
            sum = 0;
            els = 0;

            high = array.Max();

            low = array.Where(x => x != 0).Min();

            foreach (int number in array)
            {
                if(number != 0)
                {
                    sum += number;
                    els += 1;
                }
            }

            avg = Convert.ToDouble(sum) / Convert.ToDouble(els);
        }

    }
}
