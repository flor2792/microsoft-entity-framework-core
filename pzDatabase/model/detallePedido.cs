using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.model
{
    public class detallePedido
    {
        public int id { get; set; }
        public List<pedido> pedido { get; set; }
        public int subtotal { get; set; }
        public int idPizza { get; set; }
        public int cantidad { get; set; }
        public string tipo { get; set; }
        public int tamaño { get; set; }

    }
}
