﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSIS301.DitoLangMe.API.Infrastructure.Domain.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }

        public Guid? UserId { get; set; } 
    }
}
