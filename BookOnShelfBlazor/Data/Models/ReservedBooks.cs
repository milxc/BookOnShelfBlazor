using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data.Models
{
    public class ReservedBooks
    {
        [Key]
        public int ReservedBooksId { get; set; }
        [Required]
        [ForeignKey("FkBookId")]
        public Books BookId { get; set; }
        [Required]
        [ForeignKey("FkUserId")]
        public ApplicationUser UserId { get; set; }
        [Required]
        public DateOnly ReservedBeginDate { get; set; }
    }
}
