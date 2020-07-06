using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BSIS301.DitoLangMe.DataTransferObjects.Groups
{
    public class AddGroup
    {
        [Required]
        public Guid? UserId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

