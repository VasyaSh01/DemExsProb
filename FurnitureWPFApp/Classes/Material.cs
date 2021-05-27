using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureWPFApp.Classes
{
    public class Material
    {
        public string VendorCode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal Length { get; set; }
        public int Quantity { get; set; }
        public string MaterialType { get; set; }
        public decimal Price { get; set; }
        public string Gost { get; set; }
        public string MainSupplier { get; set; }
    }
}
