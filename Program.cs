using System;
using System.Globalization;
using Pedidos.Entities;
using Pedidos.Entities.Enums;


namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Client Data : \n\n");

            Console.Write("Name: ");
            string ClientName = Console.ReadLine();

            Console.Write("Email: ");
            string ClientEmail = Console.ReadLine();

            Console.Write("Birth Date: ");
            DateTime ClientBirth = DateTime.Parse( Console.ReadLine()  ) ;

            Client client = new Client(ClientName , ClientEmail , ClientBirth);

            Order order = new Order(DateTime.Now, OrderStatus.Pending_Payment, client);

            Console.Write("\nHow many Items to this Order : ");
            int nItems = int.Parse( Console.ReadLine()) ;

            for (int i = 0; i < nItems; i++)
            {

                Console.Write("\nProduct Name : ");
                string ProdName = Console.ReadLine();

                Console.Write("Product Price : $ ");
                double ProdPrice = double.Parse(Console.ReadLine());

                Product Product = new Product(ProdName, ProdPrice);


                Console.Write("Quantity : ");
                int Quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem( Quantity, ProdPrice, Product );

                order.AddItem(item);

            }

            Console.WriteLine("\n\n" + order);

        }
    }
}
