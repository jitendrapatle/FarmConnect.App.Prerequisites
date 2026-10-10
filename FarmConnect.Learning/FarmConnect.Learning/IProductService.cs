using System;
using System.Collections.Generic;
using System.Text;

namespace FarmConnect.Learning
{
    internal interface IProductService
    {
        decimal CalculateTotal(Product product, int quantity);
    }
}
