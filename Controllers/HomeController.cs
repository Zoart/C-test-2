using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using delete.Models;
using System.Collections.Generic;

namespace delete.Controllers;

public class HomeController : Controller
{
    public ViewResult Index() {

        ShoppingCart cart 
        = new ShoppingCart { Products = Product.GetProducts() };
        decimal cartTotal = cart.TotalPrices();

        List<string> results = new List<string>();
        foreach (Product p in Product.GetProducts()) {
            string name = p?.Name ?? "<No Name>";
            decimal? price = p?.Price ?? 0;
            string relatedName = p?.Related?.Name ?? "<None>";
            // results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, total: {cartTotal}");
        }
        return View(results);
    }
}
