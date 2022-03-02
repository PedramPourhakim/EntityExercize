using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityExercize.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public DateTime CreationDate { get; set; }
        public Product(string name,double unitprice)
        {
            Name = name;
            UnitPrice = unitprice;
            CreationDate = DateTime.Now;
        }
    }
}
