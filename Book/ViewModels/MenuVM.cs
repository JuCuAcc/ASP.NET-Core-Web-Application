using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Book.ViewModels
{
    public class MenuVM
    {
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Display(Name = "Controller")]
        public string ControllerName { get; set; }

        [Display(Name = "Action")]
        public string ActionName { get; set; }

        public MenuVM() { }

        public MenuVM(string roleName, string controllerName, string actionName):this()
        {
            RoleName = roleName;
            ControllerName = controllerName;
            ActionName = actionName;
        }
    }
}
