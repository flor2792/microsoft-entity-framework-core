using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pzDatabase.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.config
{
    public class ingredienteConfig
    {
        public ingredienteConfig(EntityTypeBuilder<ingrediente> entityBuilder)
        {
            entityBuilder.Property(x => x.nombre).IsRequired().HasMaxLength(500);
            /*public int id { get; set; }
        public string nombre { get; set; }*/
        }
    }
}
