using System.ComponentModel.DataAnnotations;

namespace BookOnShelfBlazor.Data.Models
{
    public class Languages
    {
        [Key]
        public int LanguageId { get; set; }
        [Required]
        [StringLength(50)]
        public string LanguageName { get; set; }
    }
}
