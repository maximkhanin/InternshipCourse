using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private BookContext db = new BookContext();

        public async Task<ActionResult> Index()
        {
            var books = await db.Books.ToListAsync();
            ViewBag.Books = books;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public async Task<string> Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            await Task.Run(() =>
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
            });
            return "Thanks," + purchase.Person + ", for purchase!";
        }
    }
}