using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Products // Listing 1.4
{
    class Product_csh4
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal? price;
        public decimal? Price { get { return price; } }

        public int SupplierId { get; set; }

        public Product_csh4()
        {

        }

        public Product_csh4(string name, int supplierId, decimal? price = null) // C#4 optional parameters
        {
            this.name = name;
            this.price = price;
            SupplierId = supplierId;
        }

        public static List<Product_csh4> GetSampleProducts()
        {
            return new List<Product_csh4>
            {
                new Product_csh4(name: "Thriller", price: 12.23m, supplierId: 1),
                new Product_csh4(name: "Comedy", price: 12.13m, supplierId: 1),
                new Product_csh4(name: "Musical", price: 14.11m, supplierId: 2),
                new Product_csh4(name: "NullMovie1", supplierId: 2),
            };
        }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}
