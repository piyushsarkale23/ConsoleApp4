using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Book
    {
        private string name;
        private string author;
        private int price;


        public Book()
        {
            name = "The time machine";
            author = "HG wells";
            price = 400;
        }
        public Book(string name, string author, int price)
        {
           this. name = name;
            this.author = author;
            this.price = price;

        }
        public string Display()
        {
            return $"Book name is {name} author is {author} and price  is {price}";
        }
    }
}
