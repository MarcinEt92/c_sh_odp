using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _01_01_01_Products // listing 1.6
{
    class ProductNameComparerTwo : IComparer<Product_csh2>
    {
        public int Compare([AllowNull] Product_csh2 x, [AllowNull] Product_csh2 y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
