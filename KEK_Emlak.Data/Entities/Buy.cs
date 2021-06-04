using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Entities
{
    public class Buy:BaseEntity
    {
        public int ProductId { get; set; }
        public long Price { get; set; }
        public string BuyerId { get; set; }
    }
}
