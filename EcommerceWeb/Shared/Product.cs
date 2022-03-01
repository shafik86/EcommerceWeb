using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Shared
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public double Price { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public int CategoryId { get; set; }
        public string ProductTag { get; set; }

    }
}
