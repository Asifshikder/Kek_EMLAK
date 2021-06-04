using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KEK_Emlak.Web.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Emailinizi giriniz")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string IncorrectInput { get; set; }

        public string ReturnUrl { get; set; }
    }
}
