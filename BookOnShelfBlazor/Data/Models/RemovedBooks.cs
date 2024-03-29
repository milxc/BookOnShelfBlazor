using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data.Models
{
    public class RemovedBooks
    {
        [Key]
        public int RemovedBooksId { get; set; }
        [Required]
        [ForeignKey("FkBookId")]
        public Books Books { get; set; }
    }
}
