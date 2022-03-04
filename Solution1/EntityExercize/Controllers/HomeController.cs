using EntityExercize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityExercize.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopContext _context;
        public HomeController(ShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var product = new Product("MackBookPro",3999);
            //_context.Add(product);
            //var product2 = new Product("Ipad",1000);
            //product2.IsAvailable();
            //product2.SetDiscountRate(3);
            //_context.Add(product2);
            //var product3 = new Product("Iphone13", 2000);
            //product3.SetDiscountRate(5);
            //product3.IsAvailable();
            //_context.Add(product3);
            //_context.SaveChanges();
            //var products = _context.Products.ToList();
            //var product = _context.Products.FirstOrDefault();
            //var product = _context.Products.FirstOrDefault(x=>x.Id==2);
            //var product = _context.Products.FirstOrDefault(x => x.Name == "Ipad");
            //var products = _context.Products.Where(x=>x.Price<1000).ToList();
            //var products = _context.Products.Where(x => x.Price > 500).Where(x => x.IsInStock).ToList();
            //var exists = _context.Products.Any(x => x.Name == "Ipad" && x.IsInStock);
            //var all = _context.Products.All(x => x.Name == "Ipad" && x.IsInStock);
            //var product = _context.Products.FirstOrDefault(product => product.Id == 4);
            //if(product!= null)
            //{
            //    product.Price = 1000;
            //    product.DisCountRate = 7;
            //    _context.SaveChanges();
            //}
            //var products = _context.Products.ToList();
            //products.ForEach(product => product.IsInStock = true);
            //_context.SaveChanges();
            //var ProductsToDelete = _context.Products.Where(x => x.Name == "Iphone11").ToList();
            //foreach(var product in ProductsToDelete)
            //{
            //    product.IsRemoved = true;
            //    _context.SaveChanges();
            //}
            var products = _context.Products.Where(x => x.IsRemoved == false).ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
