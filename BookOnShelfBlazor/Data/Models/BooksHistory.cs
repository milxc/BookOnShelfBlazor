﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data.Models
{
    public class BooksHistory
    {
        [Key]
        public int BooksHistoryId { get; set; }
        [Required]
        [ForeignKey("FkBookId")]
        public Books BookId { get; set; }
        [Required]
        [ForeignKey("FkUserId")]
        public ApplicationUser UserId { get; set; }
        [Required]
        public DateOnly BorrowBeginDate { get; set; }
        [Required]
        public DateOnly BorrowEndDate { get; set; }
    }
}
