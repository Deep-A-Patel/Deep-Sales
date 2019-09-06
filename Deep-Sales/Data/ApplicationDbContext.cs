using System;
using System.Collections.Generic;
using System.Text;
using Deep_Sales.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Deep_Sales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //create a date for Comment
            modelBuilder.Entity<Comment>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            //create a date for Product
            modelBuilder.Entity<Product>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

          


            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Deep",
                LastName = "Patel",
                UserName = "deep@patel.com",
                NormalizedUserName = "DEEP@PATEL.COM",
                Email = "deep@patel.com",
                NormalizedEmail = "DEEP@PATEL.COM",
                PhoneNumber = "6159167579",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"

            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Deep7*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);


            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Electronics"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "shoes"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "watches"
                },
                new Category()
                {
                    CategoryId = 4,
                    CategoryName = "Toys"
                },
                new Category()
                {
                    CategoryId = 5,
                    CategoryName = "sunglasses"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    CategoryId = 1,
                    UserId = user.Id,
                    Description = "It is in good condition and no damage",
                    ProductName = "Iphone X",
                    Price = 600.99
                },
                new Product()
                {
                    ProductId = 2,
                    CategoryId = 2,
                    UserId = user.Id,
                    Description = "Its a limited edition of nike shoes",
                    ProductName = "Nike Sneakers",
                    Price = 300.99
                },
                new Product()
                {
                    ProductId = 3,
                    CategoryId = 3,
                    UserId = user.Id,
                    Description = "Single owner in great condition and its All gold And Dimond",
                    ProductName = "Rolex",
                    Price = 20000.00
                },
                new Product()
                {
                    ProductId = 4,
                    CategoryId = 4,
                    UserId = user.Id,
                    Description = "007 Limited edition lego set and all parts are in good condition",
                    ProductName = "007 Lego",
                    Price = 100.99
                },
                new Product()
                {
                    ProductId = 5,
                    CategoryId = 5,
                    UserId = user.Id,
                    Description = "Tom ford black and gold sunglasses in great condition",
                    ProductName = "Tom Ford",
                    Price = 150.99
                }
            );

            modelBuilder.Entity<Comment>().HasData(
               new Comment()
               {
                   CommentId = 1,
                   UserId = user.Id,
                   ProductId = 1,
                   CommentText = "Its look good in pic, and is it come with all kit?"
               },
               new Comment()
               {
                   CommentId = 2,
                   UserId = user.Id,
                   ProductId = 2,
                   CommentText = "Yo dude its my dream shoes"
               }
           );

        }
    }
}
