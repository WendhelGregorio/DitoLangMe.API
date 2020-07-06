﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BSIS301.DitoLangMe.DataTransferObjects.Groups
{
    public class UpdateGroup
    {
        [Required]
        public Guid? Id { get; set; }

        [Required]
        public Guid? UserId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
