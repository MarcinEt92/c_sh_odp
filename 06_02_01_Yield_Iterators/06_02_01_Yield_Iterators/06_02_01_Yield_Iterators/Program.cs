using System;
using System.IO;

namespace _06_02_01_Yield_Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] values = { 1, 2, 3, 4, 5 };
            IterationSample samples = new IterationSample(values, 1);

            Console.WriteLine("\nListing 6.4 - Iterators in C#2\n");

            foreach (object item in samples)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n6.3.2 - Iterators over lines in file\n");

            string fileName = @"C:\Users\mkormanx\kursy\c_sh_odp\c_sh_odp\06_02_01_Yield_Iterators\06_02_01_Yield_Iterators\06_02_01_Yield_Iterators\6_3_2.txt";



            using (TextReader reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
