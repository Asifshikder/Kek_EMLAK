using KEK_Emlak.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Organize
{
    public class CategoryMap
    {
        public CategoryMap(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name);
        }
    }
}
