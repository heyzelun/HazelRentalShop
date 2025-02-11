using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HazelRentalShop.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }  // Changed to singular

        [Required]
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }  

        [Required]
        public DateTime RentDate { get; set; }

        public DateTime? ReturnDate { get; set; }  

        [Required]
        public int Quantity { get; set; }

        public bool IsPaid { get; set; }

        public ICollection<RentalDetail> RentalDetails { get; set; } = new List<RentalDetail>();

    }
}
