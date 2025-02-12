using System.ComponentModel.DataAnnotations;

namespace HazelRentalShop.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public DateOnly DateRelease { get; set; }  

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int Rating { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public double Price { get; set; }
        public bool IsAvailable { get; set; } = true;

  
        public ICollection<Rental>? Rentals { get; set; }
        public ICollection<RentalDetail>? RentalDetails { get; set; }
    }
}
