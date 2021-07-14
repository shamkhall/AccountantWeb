﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountantWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string UserName { get; set; }
    }
}
