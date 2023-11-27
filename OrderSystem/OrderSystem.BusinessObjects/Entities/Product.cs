using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.BusinessObjects.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
