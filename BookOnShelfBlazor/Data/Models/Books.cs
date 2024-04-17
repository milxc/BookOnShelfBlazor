using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [MaxLength(800)]
        public string? Description { get; set; }
        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }
        [Required]
        [MaxLength(5)]
        public int AmountOfPages { get; set; }
        [Required]
        [MaxLength(10)]
        public int AmountAvailable { get; set; }
        [Required]
        [ForeignKey("FkGenreId")]
        public Genres GenreId { get; set; }
        [Required]
        [ForeignKey("FkLanguageId")]
        public Languages LanguageId { get; set; }
        public byte[]? FrontCover { get; set; }
        public byte[]? BackCover { get; set; }
        [MaxLength(5)]
        public int? BookRating { get; set; }

        public bool IsDeleted { get; set; }
    }
}
