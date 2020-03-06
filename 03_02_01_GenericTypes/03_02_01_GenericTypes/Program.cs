using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03_02_01_GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n$_Generic type Dictionary - listing 3.1\n");

            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            string sentence = "aa, bb, cc, dd, aa, bb, cc, ff, aa";

            //string[] listOfWords = sentence.Split(); // ,aa
            string[] listOfWords = Regex.Split(sentence, @"\W+");

            wordFrequencies = CountWords(listOfWords);

            foreach (KeyValuePair<string, int> element in wordFrequencies)
            {
                Console.WriteLine($"{element.Key} - {element.Value}");
            }


            Console.WriteLine("\n\n$_Generic type List, generic method - listing 3.2");
            Console.WriteLine("\nSquares of ints:\n");

            List<int> integers = new List<int>();
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);

            Converter<int, double> converter = SquareRoot;
            //Converter<int, double> converter = x => Math.Sqrt(x);

            List<double> doubles = integers.ConvertAll<double>(converter);

            Action<double> action = Console.WriteLine;

            doubles.ForEach(action);


            Console.WriteLine("\n\n$_Generic Method implementation inside nongeneric type - listing 3.3");

            List<string> listFromGenericMethod = MakeList<string>("1st element", "2nd element");

            Action<string> stringAction = Console.WriteLine;
            listFromGenericMethod.ForEach(stringAction);


            Console.WriteLine("\n\n$_Generic type Method - listing 3.4\n");

            Console.WriteLine($"value: a, default: {CompareToDefault<string>("a")}");
            Console.WriteLine($"value: 0, default: {CompareToDefault<int>(0)}");

            Console.WriteLine("\n\n$_Generic Pair type - listing 3.6\n");

            Pair<int, int> pair1 = new Pair<int, int>(1, 3);
            Pair<int, int> pair2 = new Pair<int, int>(1, 2);

            Console.WriteLine($"Comparing Two Pair objects equals {pair1.Equals(pair2)}\n");


            Console.WriteLine("\n\n$_Closed types - different static fields with different types - listing 3.8\n");

            TypeWithField<int>.field = "intType";
            TypeWithField<string>.field = "stringType";
            TypeWithField<DateTime>.field = "dateTypeField";

            Console.WriteLine($"Printing different static types:\n{TypeWithField<int>.PrintField()}\n{TypeWithField<string>.PrintField()}\n" +
                $"{TypeWithField<DateTime>.PrintField()}");


            Console.WriteLine("\n\n$_Static Constructors with nested generic types - 3.9\n");

            Outer<int>.Inner<DateTime, string>.DummyMethod();
            Outer<int>.Inner<int, int>.DummyMethod();
            Outer<int>.Inner<int, int>.DummyMethod(); // does not write anything on console, because constructor was invoken before
            Outer<string>.Inner<string, string>.DummyMethod();


            Console.WriteLine("\n\n$_Generic Enumerator - 3.10\n");

            CountingEnumerable counter = new CountingEnumerable();

            foreach (int x in counter)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("\n\n$_Generic Enumerator - 3.11\n");

            DemonstrateTypeOf<int>();
        }


        public static Dictionary<string, int> CountWords(string[] listOfWords)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            foreach (string word in listOfWords)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }


        public static double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }


        static List<T> MakeList<T>(T first, T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }

        // Comparing given value with default value using generic method Listing 3.4
        // CompareToDefault makes neccessary to use this method only with types that implement the interface
        // implementation of interface not required?
        
        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }


        // Comparing references ising == operators - Listing 3.5

        static bool AreReferencesEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }

        static void DemonstrateTypeOf<X>()
        {
            Console.WriteLine(typeof(X));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.WriteLine(typeof(List<X>));
            Console.WriteLine(typeof(Dictionary<string, X>));
            Console.WriteLine(typeof(List<long>));

        }

    }

    // every closed type has its own set of static fields

    class TypeWithField<T>
    {
        public static string field;

        public static string PrintField()
        {
            return $"{field} : {typeof(T).Name}";
        }
    }

    public class Outer<T>
    {
        public class Inner<U, V>
        {
            static Inner()
            {
                Console.WriteLine($"{typeof(T)} - {typeof(U)} - {typeof(V)}");
            }

            public static void DummyMethod()
            {

            }
        }
    }

}
