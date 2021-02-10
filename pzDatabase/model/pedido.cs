using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.model
{
    public class pedido
    {

        public int id { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fecha { get; set; }
        public int estado { get; set; }//enEspera-enProceso-terminado-cancelado (cancelar: enEspera o terminado. NoCancelar: enProceso)
        public int demora { get; set; }




    }
}
