using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWords
{
    public class SortWords
    {
        public static void Main()
        {
        }

        public static void SortAndDisplayWords(params string[] words)
        {
            Array.Sort(words);

            foreach(String word in words)
            {
                Write(word + " ");
            }
        }
    }
}
