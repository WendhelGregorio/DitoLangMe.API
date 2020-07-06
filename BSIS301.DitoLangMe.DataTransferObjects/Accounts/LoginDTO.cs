using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BSIS301.DitoLangMe.DataTransferObjects.Accounts
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Please type- in email address")]
        [EmailAddress(ErrorMessage = "Please type- in valid email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password id required to login.")]
        public string PassWord { get; set; }
    }
}
