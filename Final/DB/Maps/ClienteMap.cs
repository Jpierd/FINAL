using Final.Models;
using System.Data.Entity.ModelConfiguration;

namespace Final.DB.Maps
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            HasKey(o => o.Id);

            ToTable("Clientes");
        }
    }
}