﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Book.ViewModels
{
    public class CreateRoleVM
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
