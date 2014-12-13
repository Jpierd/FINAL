using Final.Models;
using System.Data.Entity.ModelConfiguration;

namespace Final.DB.Maps
{
    public class DetalleVentaMap: EntityTypeConfiguration<DetalleVenta>
    {
        public DetalleVentaMap()
        {
            HasKey(o => o.Id);

            ToTable("DetalleVenta");
        }
    }
}