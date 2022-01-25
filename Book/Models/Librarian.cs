using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;



namespace Book.Models
{
    public class Librarian
    {
        [Key]
        public int LibrarianId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "The First Name is required.")]
        [MinLength(5, ErrorMessage = "The First Name must be atleast 5 characters")]
        [MaxLength(15, ErrorMessage = "The First Name cannot be more than 15 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The Last Name should be between 5 to 15 characters")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "Male";

        [Required]
        [Range(25, 55, ErrorMessage = "Age Must be in between 25 to 55")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Experience must be in between 1 to 25 years.")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperience { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [DisplayName("Salary")]
        [Required(ErrorMessage = "The Salary is required.")]
        [Range(10000, 20000)]
        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public float Salary { get; set; }


        [DisplayName("Insuranced")]
        [DefaultValue(0)]
        public bool HasInsurance { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Please enter PhoneNumber as 01234567890, 012-345-67890, (012)-345-67890.")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.PostalCode)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [DataType(DataType.PostalCode)]
        public string PinCode { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Shift Time")]
        public DateTime ShiftTime { get; set; }

        // Foreign Table
        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();

        [DisplayName("Image")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Please choose the Profile Photo")]
        [Display(Name = "Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }

    }

    public enum Qualifications
    {
        SSC,
        HSC,
        Honours,
        Masters,
        Others
    }
 
}
