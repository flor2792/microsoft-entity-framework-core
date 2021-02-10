using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pzDatabase.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.config
{
    public class pedidoConfig
    {

        public pedidoConfig(EntityTypeBuilder<pedido> entityBuilder)
        {
  
            entityBuilder.Property(x => x.nombreCliente).IsRequired();

            entityBuilder.Property(x => x.fecha).IsRequired();

            entityBuilder.Property(x => x.estado).IsRequired();

            entityBuilder.Property(x => x.demora).IsRequired();



           /*public int id { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fecha { get; set; }
        public int estado { get; set; }//enEspera-enProceso-terminado-cancelado (cancelar: enEspera o terminado. NoCancelar: enProceso)
        public int demora { get; set; }*/
    }
    }
}
