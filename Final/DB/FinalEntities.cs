using Final.DB.Maps;
using Final.Models;
using System.Data.Entity;

namespace Final.DB
{
    public class FinalEntities: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new VentaMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new DetalleVentaMap());
        }
    }
}