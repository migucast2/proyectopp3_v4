using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.BusinessObjects.Entities
{
    public class OrdenItem
    {
        public ProductoOrden Producto { get; set; }
        public int Cantidad { get; set; }
        public double TotalItem { get; set; }
    }
}
