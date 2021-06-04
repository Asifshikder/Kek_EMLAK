using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class IndexModel
    {
        public List<ProductModel> Products { get; set; }
        public List<SellerModel> Sellers { get; set; }
    }

    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public long Area { get; set; }
        public string DisplayImage { get; set; }
    }
    public class SellerModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public string UserTypeName { get; set; }
    }
    public class MemberModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserImage { get; set; }
        public string UserTypeName { get; set; }
    }
}
