using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class PasswordVM
    {
        public string Email { get; set; }
        public string UserID { get; set; }
        public string BaseCode { get; set; }
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir")]

        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "Şifre Çok Kısa")]
        public string Password { get; set; }

        public string Errormessage { get; set; }
    }
}
