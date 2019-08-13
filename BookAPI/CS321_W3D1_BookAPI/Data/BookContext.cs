using System;
using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace CS321_W3D1_BookAPI.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        // This method runs once when the DbContext is first used.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=books.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Grapes of Wrath", Author = "John Steinbeck", Category = "Historical Fiction" },
                new Book { Id = 2, Title = "Cannery Row", Author = "John Steinbeck", Category = "Historical Fiction" },
                new Book { Id = 3, Title = "The Shining", Author = "Stephen King", Category = "Horror" }
                );
        }

    }
}

