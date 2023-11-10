using Methods;

Product product1 = new Product();
product1.Name = "Apple";
product1.Price = 15;
product1.Description = "Amasya's Apples";

Product product2 = new Product();
product2.Name = "Watermalon";
product2.Price = 15;
product2.Description = "Diyarbakir's Watermalons";

Product[] products = new Product[] {  product1, product2 };

foreach (var product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("---------------------------------");
}

Console.WriteLine("---------------Methods---------------");

CartManager cartManager = new CartManager();

cartManager.Add(product1);
cartManager.Add(product2);
