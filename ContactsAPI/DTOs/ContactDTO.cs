namespace ContactsAPI.DTOs
{
    public class ContactDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
