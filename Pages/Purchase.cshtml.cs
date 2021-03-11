using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Euphrates.Infrastructure;
using Euphrates.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Euphrates.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookRepository repository;

        //Constructor
        public PurchaseModel (IBookRepository repo)
        {
            repository = repo;
        }

        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.RemoveLine(book);

            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
