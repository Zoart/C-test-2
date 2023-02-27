using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delete.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}