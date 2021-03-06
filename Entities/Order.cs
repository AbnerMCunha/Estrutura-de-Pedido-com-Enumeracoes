using System;
using System.Globalization;
using Pedidos.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pedidos.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client) : this()
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Itens)
            {
                total += item.Total();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order Status : " + Status);
            sb.AppendLine("Client : " + Client.Name + " (" + Client.Birth + ") - " + Client.Email );
            sb.AppendLine("Order Items : " + Itens.Count.ToString() );

            foreach (OrderItem item in Itens)
            {
                sb.AppendLine( item.Produto.Name + 
                    ", $ " + item.Price.ToString( "F2" , CultureInfo.InvariantCulture )  +   
                    ", Quantity: " + item.Quantity.ToString() + 
                    ", SubTotal: " + item.Total().ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
            sb.AppendLine("\nTotal Price : " + Total() );
            
            return sb.ToString();
        }

    }
}
