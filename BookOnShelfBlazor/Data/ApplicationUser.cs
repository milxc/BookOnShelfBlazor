using BookOnShelfBlazor.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOnShelfBlazor.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //[ForeignKey("FkUserInfo")]
        //public UserInfo? UserInfo { get; set; }

        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? MiddleName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(10)]
        public int? PhoneNumber { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        [MaxLength(100)]
        public string? City { get; set; }
        [MaxLength(100)]
        public string? Street { get; set; }
        [MaxLength(10)]
        public int? HouseNumber { get; set; }
        [MaxLength(5)]
        public string? HouseNumberAddition { get; set; }
        [MaxLength(6)]
        public string? PostalCode { get; set; }

        public byte[]? ProfilePicture { get; set; }
    }

}
