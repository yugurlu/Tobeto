using System;
namespace Methods
{
	public class CartManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("Product added to cart: " + product.Name);
		}
	}
}

