using Final.Models;
using System.Data.Entity.ModelConfiguration;

namespace Final.DB.Maps
{
    public class VentaMap: EntityTypeConfiguration<Venta>
    {
        public VentaMap()
        {
            HasKey(o => o.Id);

            ToTable("Ventas");

            HasMany(o => o.Detalle)
                .WithRequired(o => o.Venta)
                .HasForeignKey(o => o.VentaId);
        }
    }
}