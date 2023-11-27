using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.BusinessObjects.Entities
{
    public class Orden
    {
        public int OrdenId { get; set; }
        public DateTime FechaOrden { get; set; }
        public OrdenDetalle OrdenDetalle { get; set; }
        public double Total { get; set; }

    }
}
