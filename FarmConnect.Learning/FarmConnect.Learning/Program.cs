using FarmConnect.Learning;



Product product = new Product
{
    Id = 1,
    Name = "Apple",
    Price = 120m,
    Stock = 10
};
//ProductService productService = new ProductService();
IProductService productService = new ProductService();

decimal total = productService.CalculateTotal(product, 3);

Console.WriteLine($"Product {product.Name}");
Console.WriteLine($"Order total: {total}");

Console.ReadLine();
