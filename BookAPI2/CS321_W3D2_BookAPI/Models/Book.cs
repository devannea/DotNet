using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W3D2_BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
