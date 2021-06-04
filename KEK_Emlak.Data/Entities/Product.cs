using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            Buy = new HashSet<Buy>();
            Sell = new HashSet<Sell>();
        }
        public string Name { get; set; }
        public string Details { get; set; }
        public string DisplayImage { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public long Price { get; set; }
        public long Area { get; set; }
        public string Location { get; set; }
        public string AddedBy { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Buy> Buy { get; set; }
        public virtual ICollection<Sell> Sell { get; set; }
    }
}
