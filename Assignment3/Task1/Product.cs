using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

       public  Product (string name,double price,string color,  string Description):this( name, price)
        {
            this.Color = color;
            this.Description = Description;
        }

        public Product(string name, double price):this()  
        {
            this.Name = name;
            this.Price = price;


        }

        public Product()
        {
            
        }
    }
}
