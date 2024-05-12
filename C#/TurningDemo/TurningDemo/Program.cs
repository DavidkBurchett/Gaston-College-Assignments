using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurningDemo
{
    interface ITurnable
    {
        void Turn();
    }

    class Page : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a page in a book.");
        }
    }

    class Corner : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn corners to go around the block.");
        }
    }

    class Pancake : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("You turn a pancake when it's done on one side.");
        }
    }

    class Leaf : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine("A leaf turns colors in the fall.");
        }
    }

    class TurningDemo
    {
        static void Main(string[] args)
        {
        }
    }
}
