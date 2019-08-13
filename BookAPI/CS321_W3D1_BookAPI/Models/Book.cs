using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W3D1_BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
