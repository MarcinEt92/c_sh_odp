using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// Cannot implement overriden ToString() method
/// </summary>
namespace _01_01_01_Products
{
    public class Publish : Product_csh1
    {
        public static void PublishData(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(list.ToString());
            }
        }

        public static void PublishData(List<Product_csh2> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(list);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
