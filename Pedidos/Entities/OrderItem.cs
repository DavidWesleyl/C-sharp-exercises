﻿using System;
using System.Globalization;

namespace Pedidos.Entities
{
	internal class OrderItem
	{
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
            
        }

		public OrderItem(int quantity, double price, Product product)
		{
			Quantity = quantity;
			Price = price;
			Product = product;
		}

		public double SubTotal()
		{
			return Quantity * Price;
		}

		public override string ToString()
		{
			return $">> Product: {Product.Name} | Price R$: {Price} |>> Quantity {Quantity} |>> Subtotal {SubTotal().ToString("f2", CultureInfo.InvariantCulture)} ";
		}



	}
}
