using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.ViewModels
{
    public class UserShorthandVM
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public UserShorthandVM()
        {

        }

        public UserShorthandVM(string id, string name):this()
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
