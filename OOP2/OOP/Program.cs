using OOP;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 2400;
product1.UnitsInStock = 65;

Product product2 = new Product() { Id = 2, CategoryId = 3, ProductName = "Koltuk",
    UnitPrice = 3400, UnitsInStock = 90 };

//PascalCase   //camelCase
ProductManager productManager = new ProductManager();
productManager.Add(product1);



