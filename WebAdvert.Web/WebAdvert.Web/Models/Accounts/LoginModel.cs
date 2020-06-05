using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please enter username")]
        [Display(Name ="Email / Username")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [Display(Name ="Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
