using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Produto { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product produto)
        {
            Quantity = quantity;
            Price = price;
            Produto = produto;
        }

        public double Total()
        {
            return Quantity* Price;
        }


    }
}
