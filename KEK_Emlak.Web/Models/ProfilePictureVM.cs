using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class ProfilePictureVM
    {
        public IFormFile ImageFile { get; set; }
    }
}
