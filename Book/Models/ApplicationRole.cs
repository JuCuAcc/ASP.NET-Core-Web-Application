using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace Book.Models
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole():base()
        {

        }
        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string controllerName, string actionName) : base(roleName)
        {
            base.Name = roleName;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
        }

        [Display(Name = "Controller")]
        public string ControllerName { get; set; }

        [Display(Name = "Action")]
        public string ActionName { get; set; }
    }
}
