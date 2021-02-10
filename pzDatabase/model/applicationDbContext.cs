using Microsoft.EntityFrameworkCore;
using pzDatabase.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.model
{
    class applicationDbContext: DbContext//recordar heredamos de la dbcontexrt
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Pizzeria;Integrated Security=True");
        }//Data Source=localhost;Initial Catalog=master;Integrated Security=True


        public DbSet<detallePedido> detallePedido { get; set; }
        public DbSet<factura> factura { get; set; }
        public DbSet<ingrediente> ingrediente { get; set; }
        public DbSet<pedido> pedido { get; set; }//def modelos
        public DbSet<pizza> pizza { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)//creando entidades
        {//config de los atrib de cada modelo

            new detallePedidoConfig(modelBuilder.Entity<detallePedido>());

            new facturaConfig(modelBuilder.Entity<factura>());

            new ingredienteConfig(modelBuilder.Entity<ingrediente>());

            new pedidoConfig(modelBuilder.Entity<pedido>());

            new pizzaConfig(modelBuilder.Entity<pizza>());//mB tiene t/las entidades(pizza,pedido) que definimos en la carpeta config... 
                                                          //es del tipo typeBuider como en pizzaConfig (..EntityTypeBuilder<pizza>..)
                                                          //entityBuilder -> lo recibe y le ponemos todas las propertis

            base.OnModelCreating(modelBuilder);
        }

    }
}
