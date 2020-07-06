using BSIS301.DitoLangMe.DataTransferObjects.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSIS301.DitoLangMe.DataTransferObjects.Users
{
    public class UpdateUserViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

    }
}
