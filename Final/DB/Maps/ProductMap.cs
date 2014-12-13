using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Final.Models;

namespace Final.DB.Maps
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(o => o.Id);

            ToTable("Products");
        }
    }
}