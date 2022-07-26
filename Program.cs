using System;
using ProjetoIntermediario.Entities;
using ProjetoIntermediario.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Delivered.ToString();
            Console.WriteLine(txt);

            OrderStatus or = (OrderStatus)Enum.Parse(typeof(OrderStatus), "PendingPayment");
            Console.WriteLine(or);
        }
    }
}
