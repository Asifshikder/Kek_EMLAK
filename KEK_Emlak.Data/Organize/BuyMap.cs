using KEK_Emlak.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Organize
{
   public class BuyMap
    {
        public BuyMap(EntityTypeBuilder<Buy> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.BuyerId);
            builder.Property(m => m.ProductId);
        }
    }
}
