using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euphrates.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFName = "Victor",
                        AuthorLName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageNumber = 1488,
                        Price = 9.95
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFName = "Doris",
                        AuthorLName = "Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageNumber = 944,
                        Price = 14.58
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFName = "Alice",
                        AuthorLName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageNumber = 832,
                        Price = 21.54
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFName = "Ronald C.",
                        AuthorLName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageNumber = 864,
                        Price = 11.61
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFName = "Laura",
                        AuthorLName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        PageNumber = 528,
                        Price = 13.33
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFName = "Michael",
                        AuthorLName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        PageNumber = 288,
                        Price = 15.95
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFName = "Cal",
                        AuthorLName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageNumber = 304,
                        Price = 14.99
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFName = "Michael",
                        AuthorLName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageNumber = 240,
                        Price = 21.66
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFName = "Richard",
                        AuthorLName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        PageNumber = 400,
                        Price = 29.16
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFName = "John",
                        AuthorLName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        PageNumber = 642,
                        Price = 15.03
                    },

                    //My added books
                    new Book
                    {
                        Title = "Red Rising",
                        AuthorFName = "Pierce",
                        AuthorLName = "Brown",
                        Publisher = "Del Rey Books",
                        ISBN = "978-0345539786",
                        Classification = "Fiction",
                        Category = "Sci-fi",
                        PageNumber = 382,
                        Price = 16.81
                    },
                    new Book
                    {
                        Title = "The Great Gatsby",
                        AuthorFName = "F. Scott",
                        AuthorLName = "Fitzgerald",
                        Publisher = "Independent",
                        ISBN = "979-8599768029",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageNumber = 184,
                        Price = 7.95
                    },
                    new Book
                    {
                        Title = "The $100 Startup",
                        AuthorFName = "Chris",
                        AuthorLName = "Guillebeau",
                        Publisher = "Currency",
                        ISBN = "978-0307951526",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        PageNumber = 304,
                        Price = 14.89
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
