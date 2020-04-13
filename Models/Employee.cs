using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration.Models
{
    public class Employee
    {
       [Key]
        public int EmployeeId { get; set; }
        [MaxLength(100)]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [MaxLength(100)]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "This field is required")]
        public string Position { get; set; }

        
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; }
    }
}
