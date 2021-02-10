using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pzDatabase.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.config
{
    public class facturaConfig
    {
        public facturaConfig(EntityTypeBuilder<factura> entityBuilder)
        {
            entityBuilder.Property(x => x.formaDePago).IsRequired().HasMaxLength(500);

            /* public int id { get; set; }
        public string formaDePago { get; set; }
        public int idPedido { get; set; }*/
        }
    }
}
