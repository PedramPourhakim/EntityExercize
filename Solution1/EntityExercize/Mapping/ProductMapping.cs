using EntityExercize.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityExercize.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Mahsoolat");
            builder.HasKey(x => x.Id);
            //builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(70).IsRequired();
            builder.Property(x => x.IsRemoved).HasColumnName("IsDeleted");
            builder.Property(x => x.IsInStock).HasColumnName("Available In Stock");
        }
    }
}
