string productName = "Apple";
decimal price = 120m;
int quantity = 3;

decimal total = CalculateTotal(price, quantity);

Console.WriteLine($"Product: {productName}");
Console.WriteLine($"Price: {price}");
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Total: {total}");

static decimal CalculateTotal(decimal price, int quantity)
{
  return price * quantity;
}