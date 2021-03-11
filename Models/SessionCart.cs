using Euphrates.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Euphrates.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }
        public virtual void AddItem (Book book, int quantity)
        {
            base.AddItem(book, quantity);
            Session.SetJson("Cart", this);
        }
        public virtual void RemoveLine (Book book)
        {
            base.RemoveLine(book);
            Session.SetJson("Cart", this);
        }

        public virtual void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
