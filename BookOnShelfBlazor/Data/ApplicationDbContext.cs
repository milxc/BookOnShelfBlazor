using BookOnShelfBlazor.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookOnShelfBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<BooksHistory> BooksHistory { get; set; }
        public DbSet<BooksWriters> BooksWriters { get; set; }
        public DbSet<BorrowedBooks> BorrowedBooks { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<RemovedBooks> RemovedBooks { get; set; }
        public DbSet<ReservedBooks> ReservedBooks { get; set; }
        //public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Writers> Writers { get; set; }
        public DbSet<BookReviews> BookReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<BooksWriters>()
            //    .HasKey(bw => new { bw.BooksWritersId, bw.WritersId });
            //modelBuilder.Entity<Writers>()
            //    .HasIndex(w => w.FirstName)
            //    .IsUnique();
            modelBuilder.Entity<Genres>()
                .HasIndex(g => g.GenreName)
                .IsUnique();
            modelBuilder.Entity<Languages>()
                .HasIndex(l => l.LanguageName)
                .IsUnique();
            //modelBuilder.Entity<UserInfo>()
            //    .HasIndex(ui => ui.PhoneNumber)
            //    .IsUnique();
            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
