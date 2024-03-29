using System.ComponentModel.DataAnnotations;

namespace BookOnShelfBlazor.Data.Models
{
    public class Genres
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }
    }
}
