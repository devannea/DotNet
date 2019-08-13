using System;
using CS321_W4D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CS321_W4D1_BookAPI.Data
{
    public class BookContext : DbContext
    {
        // TODO: implement a DbSet<Book> property
        public DbSet<Book> Books { get; set; }

        // TODO: implement a DbSet<Author> property
        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

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

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Name = "Viking Press", CountryOfOrigin = "USA", FoundedYear = 1925, HeadQuartersLocation = "NY, NY" },
                new Publisher { Id = 2, Name = "Doubleday", CountryOfOrigin = "USA", FoundedYear = 1897, HeadQuartersLocation = "NY, NY" } 
            );

            // TODO: configure some seed data in the books table
            modelBuilder.Entity<Book>().HasData(
               new Book { Id = 1, Title = "The Grapes of Wrath", Genre = "Novel", PublicationYear = 1939, OriginalLanguage = "English", AuthorId = 1, PublisherId = 1 },
               new Book { Id = 2, Title = "Cannery Row", Genre = "Regional", PublicationYear = 1945, OriginalLanguage = "English", AuthorId = 1, PublisherId = 1 },
               new Book { Id = 3, Title = "The Shining", Genre = "Horror", PublicationYear = 1977, OriginalLanguage = "English", AuthorId = 2, PublisherId = 2 }
            );

        }

    }
}

