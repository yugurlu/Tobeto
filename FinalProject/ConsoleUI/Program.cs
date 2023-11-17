
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + " - "+ product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    var result = categoryManager.GetAll();
    foreach (var category in result.Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}

ProductTest();