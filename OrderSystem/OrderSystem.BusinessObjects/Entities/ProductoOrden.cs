using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.BusinessObjects.Entities
{
    public class ProductoOrden
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
}
