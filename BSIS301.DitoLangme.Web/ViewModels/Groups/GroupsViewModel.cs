﻿using BSIS301.DitoLangme.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSIS301.DitoLangme.Web.ViewModels.Groups
{
    public class GroupsViewModel
    {
        public Page<GroupViewModel> Groups { get; set; }
    }
}

