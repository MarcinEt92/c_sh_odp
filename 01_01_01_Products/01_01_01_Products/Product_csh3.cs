using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Products  // Listing 1.3
{
    class Product_csh3
    {
        public string Name { get; private set; }
        public decimal? Price { get; private set; }

        public Product_csh3()
        {
            
        }

        public Product_csh3(string name, decimal? price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product_csh3> GetSampleProducts()
        {
            return new List<Product_csh3>()
            {
                new Product_csh3 { Name = "D", Price = 1.11m},
                new Product_csh3 { Name = "C", Price = 3.33m},
                new Product_csh3 { Name = "B", Price = 12.32m},
                new Product_csh3(name: "A", price: 12.2m)
            };
        }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}
