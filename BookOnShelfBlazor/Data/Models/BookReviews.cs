using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data.Models
{
    public class BookReviews
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        [ForeignKey("BookId")]

        public Books BookId { get; set; }
        [Required]
        [ForeignKey("UserId")]

        public ApplicationUser UserId { get; set; }
        [Required]
        [MaxLength(5)]

        public int Rating { get; set; }

        [MaxLength(800)]
        public string? Review { get; set; }

        public int? Likes { get; set; }
    }
}
