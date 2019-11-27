using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Products
{
    class Supplier
    {
        readonly int supplierId;
        public int SupplierId { get { return supplierId; } }

        readonly string name;
        public string Name { get { return name; } }

        public Supplier()
        {
            
        }

        public Supplier(string name, int supplierId = 0)
        {
            this.name = name;
            this.supplierId = supplierId;
        }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier(name: "Krzak", supplierId: 1),
                new Supplier(name: "ABC", supplierId: 2),
                new Supplier(name: "Verv", supplierId: 3),
                new Supplier(name: "One", supplierId: 4)
                //new Supplier{ SupplierId = 123, Name = "as"} //readonly field cannot be initialised this way, only in constructor
            };
        }

        public override string ToString()
        {
            return $"{SupplierId} - {Name}";
        }
    }
}
