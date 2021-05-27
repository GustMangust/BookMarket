using System.Data.Entity;

namespace BookMarket.Models {
  public class DbInitializer : DropCreateDatabaseAlways<BookContext> {
    protected override void Seed(BookContext context) {
      context.Books.Add(new Book { BookName = "Незнайка на луне", BookPrice = 4.5m, BookAuthor = "Носов" });
      context.Books.Add(new Book { BookName = "Денискины рассказы", BookPrice = 7.4m, BookAuthor = "Драгунский" });
      context.Books.Add(new Book { BookName = "Доктор Живаго", BookPrice = 10.3m, BookAuthor = "Пастернак" });
      base.Seed(context);
    }
  }
}