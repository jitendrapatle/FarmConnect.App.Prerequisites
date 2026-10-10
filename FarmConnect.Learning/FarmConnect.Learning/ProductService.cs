using System;
using System.Collections.Generic;
using System.Text;

namespace FarmConnect.Learning
{
    public class ProductService : IProductService
    {
        public decimal CalculateTotal(Product product, int quantity) 
        {
            if(quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater then zero.");
            }
            if(product.Stock < quantity)
            {
                throw new InvalidOperationException("Insufficiant stock.");
            }
            return product.Price * quantity;
        }

    }
}
