using System;
using EnumAndComposition.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EnumAndComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ") - " + Client.Email);
            sb.AppendLine("Order Items: ");
            foreach (OrderItem items in OrderItems)
            {
                sb.Append(items.Product.Name);
                sb.Append(", $" + items.Product.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: " + items.Quantity);
                sb.AppendLine(", SubTotal: $" + items.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("TotalPrice: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem items in OrderItems)
            {

                total += items.SubTotal();

            }
            return total;
        }
    }
}
