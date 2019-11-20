using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Products  // Listing 1.1
{
    public class Product_csh1
    {
        string name;
        public string Name { get { return name; } }

        decimal? price;
        public decimal? Price { get { return price; } }

        public Product_csh1(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public Product_csh1()
        {

        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product_csh1("Ogniem i mieczem", 9.99m));
            list.Add(new Product_csh1("Potop", 14.99m));
            list.Add(new Product_csh1("Krzyżacy", 13.99m));
            list.Add(new Product_csh1("Faraon", 10.99m));
            //list.Add("Unknown word"); // Arraylist allows to Add any type to the list
            return list;
        }

        public override string ToString()
        {
            return $"{name} - {price}";
        }
    }
}
