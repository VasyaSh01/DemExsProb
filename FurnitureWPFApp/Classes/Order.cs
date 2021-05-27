using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureWPFApp.Classes
{
    public class Order
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string OrderName { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public string ResponsibleManager { get; set; }
        public decimal Price { get; set; }
        public DateTime PlannedCompletionDate { get; set; }
        public string OrderingSchemes { get; set; }
    }
}
