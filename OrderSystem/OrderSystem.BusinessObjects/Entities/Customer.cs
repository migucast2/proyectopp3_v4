using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.BusinessObjects.Entities
{
    public class Customer
    {
        public int DNI { get; set; }
        public string Name { get; set; }

        public int LastName { get; set; }
    }
}
