using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Book.ViewModels
{
    public class BooksVM: EditImageVM
    {

        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public int Edition { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }


        [DataType(DataType.Time)]
        [Display(Name = "Publishing Time")]
        public DateTime PublishingTime { get; set; }
        public string Venue { get; set; }
        public string BookPicture { get; set; }

    }
}
