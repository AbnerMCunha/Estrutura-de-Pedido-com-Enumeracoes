using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", $ " + Price.ToString("F2" , CultureInfo.InvariantCulture )  ;
        }

    }
}
