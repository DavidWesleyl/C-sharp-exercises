using Pedidos.Entities.Enum;
using System;
using System.Text;
using System.Globalization;

namespace Pedidos.Entities
{
	internal class Order
	{
        public DateTime Moment { get; set; } = DateTime.Now;

        public OrderStatus Status { get; set; }

        public Clients Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();



        public Order()
        {

        }

		public Order(DateTime moment, OrderStatus status, Clients client)
		{
			Moment = moment;
			Status = status;
			Client = client;
		}

		public void AddItem(OrderItem item)
		{
			Items.Add(item);
		}

		public void RemoveItem(OrderItem item)
		{
			Items.Remove(item);
		}

		public double Total()
		{
			double sum = 0.0;

			foreach (OrderItem item in Items)
			{
				sum += item.SubTotal();
			}

			return sum;

		}

		public override string ToString()
		{
			StringBuilder info = new StringBuilder();

			info.AppendLine($"Order moment: {Moment.ToString("ddd/dd/MM/yyyy, hh:mm:ss")}");
			info.AppendLine($"Order Status: {Status}");
			info.AppendLine($"Client: {Client}");
			info.AppendLine();
			info.AppendLine("O r d e r  i t e m s ");
			info.AppendLine();

			foreach(OrderItem item in Items)
			{
				info.AppendLine(item.ToString());
			}

			info.AppendLine();
			info.AppendLine($"Total: R$ {Total().ToString("f2", CultureInfo.InvariantCulture)}");
			






			return info.ToString();



		}



	}
}
