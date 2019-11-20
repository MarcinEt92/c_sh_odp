using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Products  // Listing 1.2
{
    public class Product_csh2
    {
        string name;
        public string Name 
        { 
            get 
            {
                return name;
            }
            private set 
            {
                name = value;
            }
        }

        decimal? price;
        public decimal? Price
        {
            get
            {
                return price;
            }
            private set
            {
                price = value;
            }
        }

        public Product_csh2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product_csh2> GetSampleProducts()
        {
            List<Product_csh2> list = new List<Product_csh2>();
            list.Add(new Product_csh2(name: "Star Wars", price: 9.99m));
            list.Add(new Product_csh2("Hobbit", 14.99m));
            list.Add(new Product_csh2("Lord of the rings", 8.99m));
            // list.Add("abc"); // attempt to add string to list fails, it requires object values
            return list;
        }

        public override string ToString()
        {
            return $"{name} - {price}";
        }
    }
}
