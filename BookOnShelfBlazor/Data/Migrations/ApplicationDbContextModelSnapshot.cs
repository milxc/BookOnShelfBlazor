﻿// <auto-generated />
using System;
using BookOnShelfBlazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookOnShelfBlazor.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("HouseNumber")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("HouseNumberAddition")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BookReviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("FkBookid")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("Likes")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<int?>("Reported")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.HasKey("ReviewId");

                    b.HasIndex("FkBookid");

                    b.HasIndex("FkUserId");

                    b.ToTable("BookReviews");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.Books", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AmountAvailable")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("AmountOfPages")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<byte[]>("BackCover")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("BookRating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<int>("FkGenreId")
                        .HasColumnType("int");

                    b.Property<int>("FkLanguageId")
                        .HasColumnType("int");

                    b.Property<byte[]>("FrontCover")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUnavailable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.HasIndex("FkGenreId");

                    b.HasIndex("FkLanguageId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BooksHistory", b =>
                {
                    b.Property<int>("BooksHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksHistoryId"));

                    b.Property<DateOnly>("BorrowBeginDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("BorrowEndDate")
                        .HasColumnType("date");

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BooksHistoryId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkUserId");

                    b.ToTable("BooksHistory");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BooksInAwaitOfGetting", b =>
                {
                    b.Property<int>("BooksInAwaitOfGettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksInAwaitOfGettingId"));

                    b.Property<DateOnly>("BeginDate")
                        .HasColumnType("date");

                    b.Property<int>("BookId1")
                        .HasColumnType("int");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("UserIdId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BooksInAwaitOfGettingId");

                    b.HasIndex("BookId1");

                    b.HasIndex("UserIdId");

                    b.ToTable("BooksInAwaitOfGetting");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BooksWriters", b =>
                {
                    b.Property<int>("BooksWritersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksWritersId"));

                    b.Property<int>("FkBookid")
                        .HasColumnType("int");

                    b.Property<int>("FkWritersId")
                        .HasColumnType("int");

                    b.HasKey("BooksWritersId");

                    b.HasIndex("FkBookid");

                    b.HasIndex("FkWritersId");

                    b.ToTable("BooksWriters");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BorrowedBooks", b =>
                {
                    b.Property<int>("BorrowedBooksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowedBooksId"));

                    b.Property<DateOnly>("BorrowBeginDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("BorrowEndDate")
                        .HasColumnType("date");

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BorrowedBooksId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkUserId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.Genres", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.HasIndex("GenreName")
                        .IsUnique();

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.Languages", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LanguageId");

                    b.HasIndex("LanguageName")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.ReservedBooks", b =>
                {
                    b.Property<int>("ReservedBooksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservedBooksId"));

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<string>("FkUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly>("ReservedBeginDate")
                        .HasColumnType("date");

                    b.HasKey("ReservedBooksId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkUserId");

                    b.ToTable("ReservedBooks");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.Writers", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriterId"));

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("WriterId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BookReviews", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Books", "Bookid")
                        .WithMany()
                        .HasForeignKey("FkBookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", "UserId")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bookid");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.Books", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Genres", "GenreId")
                        .WithMany()
                        .HasForeignKey("FkGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.Models.Languages", "LanguageId")
                        .WithMany()
                        .HasForeignKey("FkLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenreId");

                    b.Navigation("LanguageId");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BooksHistory", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Books", "BookId")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", "UserId")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BooksInAwaitOfGetting", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Books", "BookId")
                        .WithMany()
                        .HasForeignKey("BookId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BooksWriters", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Books", "Bookid")
                        .WithMany()
                        .HasForeignKey("FkBookid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.Models.Writers", "WritersId")
                        .WithMany()
                        .HasForeignKey("FkWritersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bookid");

                    b.Navigation("WritersId");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.BorrowedBooks", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Books", "BookId")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", "UserId")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("BookOnShelfBlazor.Data.Models.ReservedBooks", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.Models.Books", "BookId")
                        .WithMany()
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", "UserId")
                        .WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookOnShelfBlazor.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
