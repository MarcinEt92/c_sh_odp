using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04_01_01_Nullables
{
    class Product : IComparer<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Popularity { get; set; }

        public int Compare(Product first, Product second)
        {
            int ret = second.Popularity.CompareTo(first.Popularity);
            if(ret != 0)
            {
                return ret;
            }

            ret = first.Price.CompareTo(second.Price);
            if (ret != 0)
            {
                return ret;
            }

            ret = first.Name.CompareTo(first.Name);
            return ret;
        }

        public static List<Product> ReturnSampleList()
        {
            return new List<Product>()
            {
                new Product{Name = "Book", Price = 2, Popularity = 5},
                new Product{Name = "Bike", Price = 800, Popularity = 6},
                new Product{Name = "Laptop1", Price = 700, Popularity = 10},
                new Product{Name = "Laptop2", Price = 700, Popularity = 9},
                new Product{Name = "Laptop2", Price = 650, Popularity = 9},
                new Product{Name = "Mouse", Price = 620, Popularity = 10},
            };
        }

        public override string ToString()
        {
            return $"\t{this.Name}\t - {this.Price}\t - {this.Popularity}";
        }
    }
}
