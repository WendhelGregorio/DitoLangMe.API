using System;
using System.Collections.Generic;
using System.Text;

namespace BSIS301.DitoLangMe.DataTransferObjects.Accounts
{
    public class LoginResponseDTO
    {
        public Guid? Id { get; set; }

        public string UserName { get; set; }

        //public string SessionToken { get; set; }
    }
}