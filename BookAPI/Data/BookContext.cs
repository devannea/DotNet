using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // necessary namespace for DbContext
using BookAPI.Models; // necessary namespace for Book class

namespace BookAPI.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Book.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Grapes of Wrath", Author = "John Steinbeck", Category = "Historical Fiction" },
                new Book { Id = 2, Title = "Cannery Row", Author = "John Steinbeck", Category = "Historical Fiction" },
                new Book { Id = 3, Title = "The Shining", Author = "Stephen King", Category = "Horror" });
        }
    }
}
