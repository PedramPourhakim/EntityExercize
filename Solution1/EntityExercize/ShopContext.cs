using EntityExercize.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityExercize
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) :base(options)
        {

        }
    }
}
