using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euphrates.Models
{
    public class BookDbContext : DbContext
    {
        //Constructor
        public BookDbContext (DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
