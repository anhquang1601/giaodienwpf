using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
   
   public class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }

        public Product(string name, double value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }
    }
}
