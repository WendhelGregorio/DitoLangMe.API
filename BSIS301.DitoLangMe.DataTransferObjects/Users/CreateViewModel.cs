using BSIS301.DitoLangMe.DataTransferObjects.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSIS301.DitoLangMe.DataTransferObjects.Users
{
     public class CreateViewModel
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public Gender Gender { get; set; }
    }
}
