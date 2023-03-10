using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delete.Models
{
    public class Product
    {
        public Product(bool stock = true) {
            InStock = stock;
        }
       public string Name { get; set; }
       public string Category { get; set; } = "Watersports";
       public decimal? Price { get; set; }
       public Product Related { get; set; }
       public bool InStock { get; }
    //    public bool InStock { get; } = true;

       public static Product[] GetProducts() {
           Product kayak = new Product {
               Name = "Kayak",
               Category = "Water Craft",
               Price = 234M,
           };
           Product lifejacket = new Product(false) {
               Name = "Lifejacket",
               Price = 45.43M
           };

           kayak.Related = lifejacket;
           return new Product[] { kayak, lifejacket, null };
       }
    }
}