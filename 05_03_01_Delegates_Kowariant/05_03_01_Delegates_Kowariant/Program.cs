using System;
using System.Collections.Generic;
using System.IO;

namespace _05_03_01_Delegates_Kowariant
{
    class Program
    {
        delegate Stream StreamFactory();
        
        static void Main(string[] args)
        {

            Console.WriteLine("\nFactory delegate - listing 5.4.\n\n");

            MemoryStream factory = GenerateSampleData();

            using MemoryStream stream = factory;
            int data;
            while ((data = stream.ReadByte()) != -1)
            {
                Console.WriteLine(data);
            }


            Console.WriteLine("\n\nAnonymous methods used with delegate type Action<T> - listing 5.5.\n");

            printReverse("123456");
            printRoot(9);
            printMean(new double[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            Console.WriteLine("\n\nPredicate - delegate that returns a value - listing 5.7\n");
            Console.WriteLine(isEven(4));

            Console.WriteLine("\n\nAnonymous method for sorting files - listing 5.8\n");

            SortAndShowFiles("Sorting By Name", delegate (FileInfo first, FileInfo second) { return first.Name.CompareTo(second.Name); });
            SortAndShowFiles("\nSorting by Length", delegate (FileInfo first, FileInfo second) { return first.Length.CompareTo(second.Length); });

        }

        static MemoryStream GenerateSampleData()
        {
            byte[] buffer = new byte[16];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
            }
            return new MemoryStream(buffer);
        }

        static Action<string> printReverse = delegate (string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
        };

        static Action<int> printRoot = delegate (int number)
        {
            Console.WriteLine(Math.Sqrt(number));
        };

        static Action<IList<double>> printMean = delegate (IList<double> numbers)
        {
            double sum = 0;
            foreach (double value in numbers)
            {
                sum += value;
            }
            Console.WriteLine(sum / numbers.Count);
        };

        static Predicate<int> isEven = delegate (int x) { return x % 2 == 0; };

        static void SortAndShowFiles(string title, Comparison<FileInfo> sortOfOrder)
        {
            FileInfo[] files = new DirectoryInfo(@"C:\").GetFiles();

            Array.Sort(files, sortOfOrder);
            Console.WriteLine(title);

            foreach (FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} - {file.Length}");
            }
        }

    }
}
