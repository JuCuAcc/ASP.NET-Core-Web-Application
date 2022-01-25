using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Models
{
    public class Experience
    {
        public Experience()
        {

        }

        [Key]
        public int ExperienceId { get; set; }

        [ForeignKey("Librarian")]
        public int LibrarianId { get; set; }
        public virtual Librarian Librarian { get; private set; }  

        public string InstitutionName { get; set; }
        public string Designation { get; set; }
        [Required]
        public int YearsWorked { get; set; }
    }
}
