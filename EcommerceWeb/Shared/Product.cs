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
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public Metal Metal { get; set; }
        public double MetalWeight { get; set; }
        public string MetalBrand { get; set; }
        public double Weight { get; set; }
        public string Condition { get; set; }
        public double Purify { get; set; }
        public string Manufacture { get; set; }
        public string Certificate { get; set; }
        public bool IsTax { get; set; }
        public string Featured { get; set; }
        public double Price { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        
        public double Size { get; set; }
        public int CategoryId { get; set; }
        public string ProductTag { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }


    }

  
}
