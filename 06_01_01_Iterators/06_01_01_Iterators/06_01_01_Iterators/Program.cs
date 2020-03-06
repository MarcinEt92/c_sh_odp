using System;

namespace _06_01_01_Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nListing 6.1 Iterating over new collection");

            object[] values = { "a", "b", "c", "d", "e" };
            IterationSampleCollection collection = new IterationSampleCollection(values: values, startingPoint: 3);

            foreach (object item in collection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
