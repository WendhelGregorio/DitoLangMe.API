using BSIS301.DitoLangMe.DataTransferObjects.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSIS301.DitoLangMe.API.Infrastructure.Domain.Models
{
    public class User : BaseModel
    {
        public User()
        {
            this.LoginStatus = LoginStatus.Inactive;
        }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public int LoginRetries { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Latitude { get; set; }

        public long Longitude { get; set; }

        public Gender Gender { get; set; }
    }
}