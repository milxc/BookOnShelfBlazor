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
        [ForeignKey("FkBookid")]

        public Books Bookid { get; set; }

        [Required]
        [ForeignKey("FkUserId")]

        public ApplicationUser UserId { get; set; }

        [MaxLength(5)]
        public int? Rating { get; set; }

        [MaxLength(800)]
        public string? Review { get; set; }

        public int? Likes { get; set; }

        public bool IsDeleted { get; set; }

        public int? Reported { get; set; }
    }
}
