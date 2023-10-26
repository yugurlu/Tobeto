using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Yusuf";
        customer.LastName = "Ugurlu";

        Customer customer2 = new Customer()
        {
            Id = 2,
            City = "İstanbul",
            FirstName = "Yusuf",
            LastName = "Ugurlu"
        };

        Console.WriteLine(customer.FirstName);
        Console.WriteLine(customer2.FirstName);
    }
}