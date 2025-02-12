using System.ComponentModel.DataAnnotations;

namespace HazelRentalShop.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateOnly DateOfBirth { get; set; }  
        public int Age { get; set; } 
        public string Sex { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        [EmailAddress]  // Validates email format
        public string Email { get; set; } = string.Empty;
        [Required]
        [Phone]  // Validates phone number format
        public string Phone { get; set; } = string.Empty;

        public ICollection<Rental>? Rentals { get; set; } 
    }
}
