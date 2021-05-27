using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace FurnitureWPFApp.Classes
{
    public class Furniture
    {
        public int VendorCode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public string MainSupplier { get; set; }
        public string Image { get; set; }
        public string AccessoriesType { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
    }
}
