using System;
namespace OOP
{
	public class Product
	{
		public int Id { get; set; }
		public string ProductName { get; set; } = string.Empty;
		public double UnitPrice { get; set; }
		public int UnitsInStock { get; set; }

		public int CategoryId { get; set; }
	}
}

