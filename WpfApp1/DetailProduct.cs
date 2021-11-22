using System;
using System.Collections.Generic;
using System.Text;

namespace BTL
{
    class DetailProduct
    {
        public string Name { get; set; }
     
        public string Pricer { get; set; }

        public DetailProduct(string name,  string pricer)
        {
            Name = name;
            Pricer = pricer;
        }
    }
}
