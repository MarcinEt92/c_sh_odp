using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _01_01_01_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nArray List: \n");

            ArrayList arrayListOfProducts = Product_csh1.GetSampleProducts();
            
            foreach (var item in arrayListOfProducts)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nSorted Array List: listing 1.5");

            arrayListOfProducts.Sort(new ProductNameComparerOne());

            foreach (var item in arrayListOfProducts)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nFiltering products which price is above 10 Listing 1.10");
            foreach (Product_csh1 item in arrayListOfProducts)
            {
                if(item.Price > 10)
                {
                    Console.WriteLine(item);
                }
            }


            Console.WriteLine("\n\nGeneric List C#2: \n");

            List<Product_csh2> genericListOfProducts = Product_csh2.GetSampleProducts();

            foreach (var item in genericListOfProducts)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nSorted Generic List C#2: ");

            genericListOfProducts.Sort(new ProductNameComparerTwo());

            foreach (var item in genericListOfProducts)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nFiltering products which price is above 10 C#2 Listing 1.11");
            Predicate<Product_csh2> filterPredicateCsh2 = delegate (Product_csh2 x) { return x.Price > 10m; };
            List<Product_csh2> matches10mList = genericListOfProducts.FindAll(filterPredicateCsh2);

            Action<Product_csh2> printResult = Console.WriteLine; // creating delegate from existing method
            matches10mList.ForEach(printResult);

            Console.WriteLine("\nFiltering products which price is above 10 C#2 Listing 1.12");
            genericListOfProducts.FindAll(delegate (Product_csh2 x) { return x.Price > 10; }).ForEach(Console.WriteLine);


            Console.WriteLine("\n\nGeneric List C#3: \n");

            List<Product_csh3> genericListOfProductsCs3 = Product_csh3.GetSampleProducts();

            foreach (var item in genericListOfProductsCs3)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nSorted Generic List C#3: ");

            genericListOfProductsCs3.Sort(delegate (Product_csh3 x, Product_csh3 y) { return x.Name.CompareTo(y.Name); });
            
            
            foreach (var item in genericListOfProductsCs3)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nFiltering products which price is above 10 C#3 Listing 1.13");
            foreach (var item in genericListOfProductsCs3.Where(p => p.Price > 10))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nFiltering products which price is above 10 C#3 Listing 1.13 In One line");
            genericListOfProductsCs3.FindAll(p => p.Price > 10).ForEach(Console.WriteLine);

            Console.WriteLine("\n\nGeneric List C#4: \n");

            List<Product_csh4> genericListOfProductsCs4 = Product_csh4.GetSampleProducts();

            foreach (var item in genericListOfProductsCs4)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nSorted Generic List C#4: ");

            genericListOfProductsCs4.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (var item in genericListOfProductsCs4)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nSorted Generic List C#4 using linq OrderBy extension method: ");

            foreach (var item in genericListOfProductsCs4.OrderBy(p => p.Name)) // in this way original list is not being modified
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("\nDisplaying products which price has null value: ");
            foreach (var item in genericListOfProductsCs4.Where(p => p.Price == null))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDisplaying products which price is bigger than 8, listing 1.15: ");
            IEnumerable<Product_csh4> biggerThanEightProducts = from Product_csh4 p in genericListOfProductsCs4
                                          where p.Price > 10
                                          orderby p.Price, p.Name
                                          select p;
            foreach (Product_csh4 item in biggerThanEightProducts)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nCreating List Of suppliers and make connections between products and suppliers listing 1.16 ");

            List<Product_csh4> listOfProdForSuppliersCs4 = Product_csh4.GetSampleProducts();
            List<Supplier> listOfSuppCs4 = Supplier.GetSampleSuppliers();

            var filtered = from product in listOfProdForSuppliersCs4
                           join supplier in listOfSuppCs4
                             on product.SupplierId equals supplier.SupplierId
                             orderby product.Name, supplier.Name
                           select new { ProductName = product.Name, SupplierName = supplier.Name };

            foreach (var item in filtered)
            {
                Console.WriteLine($"Product Name: {item.ProductName}, Supplier Name: {item.SupplierName}");
            }


            Console.WriteLine("\nMake connections between products and suppliers from XML file listing 1.17 ");

            XDocument document = XDocument.Load("dane.xml");
            var filteredXml = from product in document.Descendants("Product")
                              join supplier in document.Descendants("Supplier")
                                on (int)product.Attribute("SupplierID") equals (int)supplier.Attribute("SupplierID")
                              where (decimal)product.Attribute("Price") > 10
                              orderby (string)product.Attribute("Name"), (string)supplier.Attribute("Name")
                              select new { ProductName = product.Attribute("Name"), SupplierName = supplier.Attribute("Name") };

            foreach (var item in filteredXml)
            {
                Console.WriteLine(item);
            }
        }
    }
}
