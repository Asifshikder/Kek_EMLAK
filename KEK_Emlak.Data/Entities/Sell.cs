using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Entities
{
    public class Sell : BaseEntity
    {
        public int ProductId { get; set; }
        public long Price { get; set; }
        public string SellerId { get; set; }
    }
}
