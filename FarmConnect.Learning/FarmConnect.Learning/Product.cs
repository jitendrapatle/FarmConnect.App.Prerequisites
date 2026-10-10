using System;
using System.Collections.Generic;
using System.Text;

namespace FarmConnect.Learning
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool isAvailable()
        {
            return Stock > 0;
        }
    }
}
