using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.BusinessObjects.Entities
{
    public class OrdenDetalle
    {
        public List<OrdenItem> Producto { get; set; } = new();
        
    }
}
