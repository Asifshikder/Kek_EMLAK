﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string UserImage { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserTypeName { get; set; }
        public string PhoneNumber { get; set; }
        public int UserTypeId { get; set; }
        public List<ProductModel> Product { get; set; }

    }
   
}
