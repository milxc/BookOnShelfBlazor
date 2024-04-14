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
        public string FirstName { get; set; }
        [StringLength(50)]
        public string? MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

    }
}
