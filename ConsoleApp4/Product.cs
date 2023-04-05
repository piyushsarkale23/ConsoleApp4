using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Product
    {
            //Create class Product → prod id, name, company & price

            //Assign values in the constructor
            //If price > 2000  give 15 % discount
            //If price< 2000  give 5 % discount

            //And display product details

            //Create two objects of product class & display the details
            private int id;
            private string name;
            private string company;
            private double price;

             
        public Product()  //non paramter 
        {
            id = 68342;
            name = "Product1";
            company = "ABC";
            price = 1200;
        }
            
        public Product(int id, string name, string company, int price)
        {
            this.id = id;
            this.name = name;
            this.company = company;
            this.price = price;
        }
      
           public string discountp()
        {
            if (price > 2000)
            {
                double DiscountPrice = price * 0.15;
                Console.WriteLine("Discounted price is " + DiscountPrice);
            }
            if (price < 2000)
            {
                double DiscountPrice1 = price * 0.05;
                Console.WriteLine("Discounted price is " + DiscountPrice1);
            }
            Console.WriteLine( $"The Product name is {name} id is {id} company name is {company} Actual price is {price} Discounted Price is {DiscountPrize}");


        }
        public string Details()
        {
                        return $"The Product name is {name} id is {id} company name is {company} Actual price is {price} Discounted Price is {DiscountPrize}";
        }


    }
}
