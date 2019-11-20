using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Products // listing 1.5
{
    class ProductNameComparerOne : IComparer
    {
        public int Compare(object x, object y)
        {
            Product_csh1 first = (Product_csh1)x;
            Product_csh1 second = (Product_csh1)y;
            return first.Name.CompareTo(second.Name);
        }
    }
}
