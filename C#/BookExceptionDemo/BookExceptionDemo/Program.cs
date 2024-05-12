using System;
using static System.Console;
using System.Globalization;

namespace BookExceptionDemo
{
    class BookExceptionDemo
    {
        static void Main(string[] args)
        {
            Book[] bookArray = new Book[5];

            for (int i = 0; i < 5; i++)
            {
                WriteLine("Enter title of Book: ");
                String title = ReadLine();
                WriteLine("Enter author of Book: ");
                String author = ReadLine();
                WriteLine("Enter price of Book: ");
                double price = Convert.ToDouble(ReadLine());
                WriteLine("Enter pages of Book: ");
                int pages = Convert.ToInt32(ReadLine());

                try
                {
                    bookArray[i] = new Book(title, author, price, pages);
                } catch (BookException e)
                {
                    WriteLine(e.Message);
                }

            }

            for (int i = 0; i < 5; i++)
            {
                WriteLine(String.Format("{0} by {1} Price {2} {3} pages.", bookArray[i].Title, bookArray[i].Author, bookArray[i].Price.ToString("C2", CultureInfo.GetCultureInfo("en-US")), bookArray[i].Pages));
            }
        }
    }

    public class Book
    {
        private String title, author;
        private double price;
        private int pages;

        public Book(String title, String author, double price, int pages)
        {
            if ((price * 10) > pages)
            {
                throw new BookException(title, price, pages);
            }
            else
            {
                this.title = title;
                this.author = author;
                this.price = price;
                this.pages = pages;
            }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public String Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if ((value * 10) > pages)
                {
                    price = value;
                    throw new BookException(title, price, pages);
                }
                else
                {
                    price = value;
                }
            }
        }
        public int Pages
        {
            get
            {
                return this.pages;
            }

            set
            {
                if(value < (price * 10))
                {
                    pages = value;
                    throw new BookException(title, price, pages);
                }
                else
                {
                    pages = value;
                }

            }
        }

    }

    public class BookException : Exception
    {
        public BookException(String title, double price, int pages) : base(String.Format("For {0}, ratio is invalid.\n...Price is ${1} for {2} pages.", title, price, pages)) { }
    }
}
