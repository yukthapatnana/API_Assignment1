﻿using System.ComponentModel.DataAnnotations;

namespace API_Assignment1.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
	}
}
