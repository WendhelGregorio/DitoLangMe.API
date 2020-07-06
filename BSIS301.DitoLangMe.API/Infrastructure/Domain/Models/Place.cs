using BSIS301.DitoLangMe.DataTransferObjects.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSIS301.DitoLangMe.API.Infrastructure.Domain.Models
{
    public class Place : BaseModel
    {
        public string Name { get; set; }

        public string EstablishmentType { get; set; }

        public Location Location { get; set; }

        public Rating Rating { get; set; }

        public DateTime LastVisited { get; set; }
    }
}
