using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityExercize.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsInStock { get; set; }
        public int DisCountRate { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
            ModifiedDate = DateTime.Now;
        }
        public void SetDiscountRate(int rate)
        {
            DisCountRate = rate;
        }
        public void IsAvailable()
        {
            IsInStock = true;
        }
    }
}
