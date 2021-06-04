using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Data.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int UserTypeId { get; set; }
        public string UserImage { get; set; }
    }
}
