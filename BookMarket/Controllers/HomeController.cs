using BookMarket.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BookMarket.Controllers {
  public class HomeController : Controller {
    BookContext bookContext = new BookContext();
    public ActionResult Index() {
      IEnumerable<Book> books = bookContext.Books;
      ViewBag.Books = books;
      return View();
    }

    public ActionResult About() {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact() {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}