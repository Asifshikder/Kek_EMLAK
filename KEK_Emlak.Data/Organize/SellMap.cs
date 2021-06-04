using KEK_Emlak.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Organize
{
   public class SellMap
    {
        public SellMap(EntityTypeBuilder<Sell> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.SellerId);
            builder.Property(m => m.ProductId);
        }
    }
}
