using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSIS301.DitoLangme.Web.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please type-in your email address.")]
        [EmailAddress(ErrorMessage = "Please type-in a valid email address.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password id required to login.")]
        public string Password { get; set; }
    }
}
