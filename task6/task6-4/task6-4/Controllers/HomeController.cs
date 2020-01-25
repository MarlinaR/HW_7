using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using task6_4.Models;
using Microsoft.EntityFrameworkCore;

namespace task6_4.Controllers
{

    public class HomeController : Controller
    {
        BookContext db;
        public HomeController(BookContext context)
        {
             db = context;


            if (db.Authors.Count() == 0)
            {
            Author author1 = new Author { Name = "Paul", Country = "USA" };
            Author author2 = new Author { Name = "Jim", Country = "England" };
            Author author3 = new Author { Name = "Max", Country = "Sweden" };
            Author author4 = new Author { Name = "Kolya", Country = "Russia" };

            Book book1 = new Book { Name = "Best", Author = author1, Count = 2 };
            Book book2 = new Book { Name = "Good", Author = author2, Count = 7 };
            Book book3 = new Book { Name = "Worst", Author = author3, Count = 9 };
            Book book4 = new Book { Name = "Milk", Author = author4, Count = 4 };
            Book book5 = new Book { Name = "Apple", Author = author1, Count = 2 };
            Book book6 = new Book { Name = "Tomato", Author = author2, Count = 7 };
            Book book7 = new Book { Name = "Olive", Author = author3, Count = 2 };
            Book book8 = new Book { Name = "Fefu", Author = author4, Count = 2 };

            db.Books.AddRange(book1, book2, book3, book4, book5, book6, book7, book8);
            db.Authors.AddRange(author1, author2, author3, author4);
            db.SaveChanges();


            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EagerLoad()
        {
            var books = db.Books
                .Include(d => d.Author)
                 .ToList();
            return View(books.ToList());
        }

        [HttpGet]
        public IActionResult ExplicitLoad()
        {
            db.Authors.Load();
            db.Books.Load();
            return View(db.Books);
        }

        [HttpGet]
        public IActionResult LazyLoad() 
        {
            var books = db.Books.ToList();
            return View(books.ToList());
        }

    }
}
