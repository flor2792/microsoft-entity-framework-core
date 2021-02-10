using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pzDatabase.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.config
{
    public class pizzaConfig
    {

        public pizzaConfig(EntityTypeBuilder<pizza> entityBuilder)
        {
            //entityBuilder.Property(x => x.tamanio);
            entityBuilder.Property(x => x.nombre).IsRequired().HasMaxLength(500);

            entityBuilder.Property(x => x.precio).IsRequired();


            /*public int id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }*/
        }


    }
}
