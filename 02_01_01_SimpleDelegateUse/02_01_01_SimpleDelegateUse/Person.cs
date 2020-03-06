using System;
using System.Collections.Generic;
using System.Text;

namespace _02_01_01_SimpleDelegateUse
{
    class Person : ICloneable
    {

        string name;
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void Say(string message)
        {
            Console.WriteLine($"{name}, message: {message}");
        }

        
    }

    class Background
    {
        public static void Note(string note)
        {
            Console.WriteLine($"Note: {note}");
        }
    }
}
