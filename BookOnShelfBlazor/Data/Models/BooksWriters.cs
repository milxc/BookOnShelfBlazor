using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data.Models
{
    public class BooksWriters
    {
        [Key]
        public int BooksWritersId { get; set; }
        [Required]
        [ForeignKey("FkBookid")]

        public Books Bookid { get; set; }
        [Required]
        [ForeignKey("FkWritersId")]
        public Writers WritersId { get; set; }
    }
}
