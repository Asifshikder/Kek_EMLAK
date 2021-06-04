using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string DisplayImage { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public IFormFile DisplayImageFile { get; set; }
        public IFormFile Image2File { get; set; }
        public IFormFile Image3File { get; set; }
        public IFormFile Image4File { get; set; }
        public IFormFile Image5File { get; set; }
        public long Price { get; set; }
        public long Area { get; set; }
        public string Location { get; set; }
        public string AddedBy { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool canBuy { get; set; }
    }
}
