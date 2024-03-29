using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookOnShelfBlazor.Data.Models
{
    public class Writers
    {
        [Key]
        public int WriterId { get; set; }
        [Required]
        [StringLength(50)]
        public string WriterName { get; set; }
    }
}
