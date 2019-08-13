using System;
using CS321_W3D2_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace CS321_W3D2_BookAPI.Data
{
    public class BookContext : DbContext
    {
        // TODO: implement a DbSet<Book> property
        public DbSet<Book> Books { get; set; }

        // TODO: implement a DbSet<Author> property
        public DbSet<Author> Authors { get; set; }

        // This method runs once when the DbContext is first used.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: use optionsBuilder to configure a Sqlite db
            optionsBuilder.UseSqlite("Data Source=books.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: configure some seed data in the authors table
            modelBuilder.Entity<Author>().HasData(
               new Author { Id = 1, FirstName = "John", LastName = "Steinbeck", BirthDate = new DateTime(1902, 2, 27)  },
               new Author { Id = 2, FirstName = "Stephen", LastName = "King", BirthDate = new DateTime(1947, 9, 21) }
            );

            // TODO: configure some seed data in the books table
            modelBuilder.Entity<Book>().HasData(
               new Book { Id = 1, Title = "The Grapes of Wrath", AuthorId = 1 },
               new Book { Id = 2, Title = "Cannery Row", AuthorId = 1 },
               new Book { Id = 3, Title = "The Shining", AuthorId = 2 }
            );

        }

    }
}

