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
            var product = new Product("Iphone11",399);
            _context.Products.Add(product);
            _context.SaveChanges();
            return View();
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
