using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.ViewModels
{
    public class RoleShorthandVM
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public RoleShorthandVM()
        {

        }

        public RoleShorthandVM(string id, string name):this()
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
