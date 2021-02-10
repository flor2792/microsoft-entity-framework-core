using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pzDatabase.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.config
{
    public class detallePedidoConfig
    {
        public detallePedidoConfig(EntityTypeBuilder<detallePedido> entityBuilder)
        {

            entityBuilder.Property(x => x.subtotal).IsRequired();

            entityBuilder.Property(x => x.idPizza).IsRequired();

            entityBuilder.Property(x => x.idPizza).IsRequired();

            entityBuilder.Property(x => x.cantidad).IsRequired();

            entityBuilder.Property(x => x.tipo).IsRequired().HasMaxLength(500);

            entityBuilder.Property(x => x.tamaño).IsRequired();
            /*public int id { get; set; }
        public int idPedido { get; set; }
        public int subtotal { get; set; }
        public int idPizza { get; set; }
        public int cantidad { get; set; }
        public string tipo { get; set; }
        public int tamaño { get; set; }*/

        }
}
}
