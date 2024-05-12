using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PaintintDemo
{
    
    class PaintintDemo
    {
        static void Main()
        {
            Room newRoom = new Room(12, 10, 9);

            WriteLine(newRoom.Area);
            WriteLine(newRoom.Gallons);
            ReadLine();
        }
    }

    public class Room
    {
        public int Area, Gallons;

        public Room(int length, int width, int height)
        {
            getArea(length, width, height);
            getGallons();
        }

        private int getArea(int length, int width, int height)
        {
            this.Area = ((length * height) * 2) + ((width * height) * 2);

            return this.Area;
        }

        private int getGallons()
        {
            this.Gallons = this.Area / 350 + 1;
            return this.Gallons;
        }
    }
}
