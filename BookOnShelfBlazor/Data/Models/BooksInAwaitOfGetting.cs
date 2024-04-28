using System.ComponentModel.DataAnnotations;

namespace BookOnShelfBlazor.Data.Models
{
    public class BooksInAwaitOfGetting
    {
        [Key]
        public int BooksInAwaitOfGettingId { get; set; }
        [Required]
        public Books BookId { get; set; }
        [Required]
        public ApplicationUser UserId { get; set; }

        public DateOnly BeginDate { get; set; }
        
        public DateOnly EndDate { get; set; }
    }
}
