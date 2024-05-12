using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class PhotoDemo
    {
        static void Main(string[] args)
        {
        }
    }

    class Photo
    {
        private int width, height;
        protected double price;

        public int Width 
        {
            get { return this.width; }

            set 
            {
                this.width = value;
                if (this.width == 8 && this.height == 10)
                {
                    this.price = 3.99;
                } else if (this.width == 10 && this.height == 12)
                {
                    this.price = 5.99;
                } else
                {
                    this.price = 9.99;
                }
            }
        }
        public int Height 
        {
            get { return this.height; }

            set
            {
                this.height = value;
                if (this.width == 8 && this.height == 10)
                {
                    this.price = 3.99;
                }
                else if (this.width == 10 && this.height == 12)
                {
                    this.price = 5.99;
                }
                else
                {
                    this.price = 9.99;
                }
            }
        }

        public double Price { get { return this.price; } }

        override
        public String ToString()
        {
            return ("the " + GetType() + " is " + this.Width + " inches wide, " + this.Height + " inches tall, and costs $" + this.Price);
        }
    }

    class MattedPhoto : Photo
    {
        private string color;

        public string Color
        {
            get { return this.color; }

            set
            {
                this.color = value;
                this.price += 10;
            }
        }
        override
        public String ToString()
        {
            return ("the " + GetType() + " is " + this.Width + " inches wide, " + this.Height + " inches tall with a " + this.color + "color, and costs $" + this.Price);
        } 
    }

    class FramedPhoto : Photo
    {
        private string material, style;

        public string Material
        {
            get { return this.material; }

            set
            {
                this.material = value;
                this.price += 25;
            }
        }
        public string Style
        {
            get { return this.style; }

            set
            {
                this.style = value;
            }
        }

        override
        public String ToString()
        {
            return ("the " + GetType() + " is " + this.Width + " inches wide, " + this.Height + " inches tall with a " + this.style + "style, a " + this.material + "material, and costs $" + this.Price);
        }
    }
}
