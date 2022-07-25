using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class ContactDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(60, ErrorMessage = "Can't be longer than 60 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(60, ErrorMessage = "Can't be longer than 60 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        [Required(ErrorMessage = "PhoneNumber is required")]
        [Phone]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}
