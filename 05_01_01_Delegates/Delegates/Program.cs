using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Plain event...");
        }

        static void LogKeyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Key event...");
        }

        static void LogMouseEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Mouse event...");
        }

        Button button = new Button();

    }
}
