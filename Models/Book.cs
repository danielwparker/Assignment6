using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Euphrates.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFName { get; set; }
        [Required]
        public string AuthorLName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int PageNumber { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
