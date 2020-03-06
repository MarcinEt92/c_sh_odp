using System;
using System.Collections.Generic;

namespace _04_01_01_Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nListing 4.1 - Nullable<T>\n");
            
            Nullable<int> x = 5;
            x = new Nullable<int>(5);
            int? y = null; // C#2
            Display(x);
            Display(y);

            Nullable<int> b = new Nullable<int>();
            Console.WriteLine($"\nb has value: {b.HasValue}");

            Nullable<int> c = null;
            Console.WriteLine($"{c.HasValue}");


            Console.WriteLine("\n\nListing 4.2 - Nullable<T> boxing, unboxing\n");

            Nullable<int> nullable = 5;

            object boxed = nullable;  // null value causes NullReferenceException
            Console.WriteLine(boxed.GetType());

            int normal = (int)boxed;
            Console.WriteLine(normal);

            nullable = (Nullable<int>)boxed;
            Console.WriteLine(nullable);

            nullable = new Nullable<int>(); // null
            boxed = nullable;
            Console.WriteLine($"Comparing boxed to null: {boxed == null} {nullable == null}");

            Console.WriteLine("Listing 4.3 uses the same example, but with abbreviated declaration of nullable types\n\n");

            Console.WriteLine("Listing 4.4. - class Person with nullable fields\n");

            Person jon = new Person("Jon", new DateTime(1993, 4, 10), new DateTime(2019, 1, 1));
            Console.WriteLine(jon.ToString());

            Person mark = new Person("Mark", new DateTime(1999, 1, 2), null);
            Console.WriteLine(mark.ToString());


            Console.WriteLine("\n\n Print Value As Int32 \n");

            PrintValueAsInt32(5);
            PrintValueAsInt32("sample");

            Console.WriteLine("\n\n ?? Operator first ?? second means, calculate first value, if it is not null then first is a final result, " +
                "otherwise second is a result of entire expression \n" );

            int? a1 = 5;
            int b1 = 10;
            int c1 = a1 ?? b1;
            Console.WriteLine($"Result of ?? operator: {c1}");

            Console.WriteLine("\nList of Products:\n");

            List<Product> listOfProducts = Product.ReturnSampleList();

            listOfProducts.ForEach(Console.WriteLine);

            listOfProducts.Sort(new Product);

            Console.WriteLine("\nAfter Sorting:\n");

            listOfProducts.ForEach(Console.WriteLine);

        }

        static void Display(Nullable<int> x)
        {
            Console.WriteLine($"HasValue: {x.HasValue}");
            if (x.HasValue)
            {
                Console.WriteLine($"Value: {x.Value}");
                Console.WriteLine($"Explicit conversion: {(int)x}");
            }
            Console.WriteLine($"GetValueOrDefault {x.GetValueOrDefault()}");
            Console.WriteLine($"getValueOrDefault {x.GetValueOrDefault(10)}");
            Console.WriteLine($"ToString: {x.ToString()}");
            Console.WriteLine($"getHashCode: {x.GetHashCode()}");
        }

        static void PrintValueAsInt32(object o)
        {
            int? nullable = o as int?;
            Console.WriteLine(nullable.HasValue ? nullable.Value.ToString() : "null") ;
        }

    }
}
