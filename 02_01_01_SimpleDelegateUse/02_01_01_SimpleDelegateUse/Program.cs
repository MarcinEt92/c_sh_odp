using System;
using System.Linq;

namespace _02_01_01_SimpleDelegateUse
{
    class Program
    {
        delegate void StringProcessor(string input);

        static void Main(string[] args)
        {
            Console.WriteLine("\nSimple delegate use - listing 2.1\n");

            Person john = new Person("John");
            Person tom = new Person("Tom");

            StringProcessor jonsVoice, tomsVoice, background;

            jonsVoice = new StringProcessor(john.Say);
            jonsVoice += new StringProcessor(tom.Say);
            jonsVoice += new StringProcessor(Background.Note);
            tomsVoice = new StringProcessor(tom.Say);
            background = new StringProcessor(Background.Note);

            jonsVoice("Hey!");
            tomsVoice.Invoke("Heyyy!");
            background("Background message!");


            // listing 2.3
            string[] strings = new string[5];
            object[] objects = strings;
            //objects[0] = john;

            object o = "str";
            Console.WriteLine(o);
            Console.WriteLine(((string)o).Length);
            Console.WriteLine(o.ToString().Length);


            Console.WriteLine("\n\nLambda expressions, Func delegate type - listing 2.5\n");
            Func<int, int, string> funcDel = (x, y) => (x * y).ToString();
            Console.WriteLine(funcDel(5, 6));

            Console.WriteLine("\n\nObject initialiser - listing 2.6\n");
            Person jason = new Person() { Name = "Jason", Age = 25 };

            Console.WriteLine("\n\nObject initialiser - listing 2.8\n");

            int? x = null;
            x = 5;

            if(x != null)
            {
                int y = x.Value;
                Console.WriteLine($"y = {y}");
            }

            int z = x ?? 10;
            Console.WriteLine($"z = {z}");

        }

        


    }
}
