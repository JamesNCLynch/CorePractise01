﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorePractise01.Persistence.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Feed> Feeds { get; set; }
    }
}
