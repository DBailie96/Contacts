using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("contact")]
    public class Contact
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(60, ErrorMessage = "Can't be longer than 60 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(60, ErrorMessage = "Can't be longer than 60 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}
