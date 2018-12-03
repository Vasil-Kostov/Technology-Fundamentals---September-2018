namespace Library.Controllers
{
    using System.Linq;
    using Library.Data;
    using Library.Models;
    using Microsoft.AspNetCore.Mvc;

    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var books = db.Books.ToList();
                return this.View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                using (var db = new LibraryDbContext())
                {
                    db.Add(book);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                if (book.Title == string.Empty || book.Title == null)
                {
                    TempData["ErrorEmptyTitle"] = "Title is required!";
                }
                if (book.Author == string.Empty || book.Author == null)
                {
                    TempData["ErrorNoAuthor"] = "Author is required!";
                }
                if (book.Price < 1)
                {
                    TempData["ErrorMinPrice"] = "The minimal price is 1";
                }

                return this.View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.Id == id);

                if (book != null)
                {
                    return this.View(book);
                }
                else
                {
                    TempData["ErrorNotExistingBook"] = $"Book with ID {id} doesn't exist";
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                using (var db = new LibraryDbContext())
                {
                    var bookToEdit = db.Books.First(b => b.Id == book.Id);

                    bookToEdit.Title = book.Title;
                    bookToEdit.Author = book.Author;
                    bookToEdit.Price = book.Price;

                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                if (book.Title == string.Empty || book.Title == null)
                {
                    TempData["ErrorEmptyTitle"] = "Title is required!";
                }
                if (book.Author == string.Empty || book.Author == null)
                {
                    TempData["ErrorNoAuthor"] = "Author is required!";
                }
                if (book.Price < 1)
                {
                    TempData["ErrorMinPrice"] = "The minimal price is 1";
                }

                return this.View(book);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.Id == id);

                if (book != null)
                {
                    return this.View(book);
                }
                else
                {
                    TempData["ErrorNotExistingBook"] = $"Book with ID {id} doesn't exist";
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                db.Remove(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}