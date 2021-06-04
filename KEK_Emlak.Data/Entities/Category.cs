using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
