using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Product
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public decimal Price { get; set; }
		public Category? Category { get; set; }

		public Product(int id, string? name, decimal price, Category? category)
		{
			Name = name;
			Price = price;
			Category = category;
		}
	}
}
