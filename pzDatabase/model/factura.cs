using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.model
{
    public class factura
    {
        public int id { get; set; }
        public string formaDePago { get; set; }
        public List<pedido> pedido { get; set; }
    }
}
