using KEK_Emlak.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Organize
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name);
            builder.Property(m => m.Details);
            builder.Property(m => m.DisplayImage);
            builder.Property(m => m.Image2);
            builder.Property(m => m.Image3);
            builder.Property(m => m.Image4);
            builder.Property(m => m.Image5);
            builder.Property(m => m.Price);
            builder.Property(m => m.Area);
            builder.Property(m => m.Location);
            builder.Property(m => m.AddedBy);
            builder.Property(m => m.CategoryId);
            builder.HasOne(m => m.Category)
                .WithMany(s => s.Product)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
