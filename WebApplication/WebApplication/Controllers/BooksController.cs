using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using System.Threading.Tasks;
 
namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        BookContext db;
        public BooksController(BookContext context)
        {
            db = context;
            if (!db.Books.Any())
            {
                var book1 = new Book { Name = "Grumpy Cat", Material = "cotton", Price = 599 };
                var book2 = new Book { Name = "Tom The Cat", Material = "cotton", Price = 499 };
                var book3 = new Book { Name = "Jerry The Mouse", Material = "synthetics", Price = 599 };
                var book4 = new Book { Name = "Mickey Mouse", Material = "plastic", Price = 1099 };
                var book5 = new Book { Name = "Minnie Mouse", Material = "plastic", Price = 399 };
                var book6 = new Book { Name = "Barbie", Material = "plastic", Price = 299 };
                var book7 = new Book { Name = "Ken", Material = "plastic", Price = 1199 };
                var book8 = new Book { Name = "Blue Sad Dog", Material = "cotton", Price = 899 };
                var book9 = new Book { Name = "Star Wars", Material = "plastic", Price = 199 };
                var book10 = new Book { Name = "Ninjago", Material = "plastic", Price = 299 };

                var mat1 = new Material { Name = "cotton" };
                var mat2 = new Material { Name = "synthetic" };
                var mat3 = new Material {Name = "plastic"};
                
                db.Materials.AddRange(mat1, mat2, mat3);
                db.Books.AddRange(book1, book2, book3, book4, book5, book6, book7, book8, book9, book10);
                db.SaveChanges();
            }
        }
 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            return await db.Books.ToListAsync();
        }
 
        // GET api/books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            Book book = await db.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
                return NotFound();
            return new ObjectResult(book);
        }
 
        // POST api/books
        [HttpPost]
        public async Task<ActionResult<Book>> Post(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
 
            db.Books.Add(book);
            await db.SaveChangesAsync();
            return Ok(book);
        }
 
        // PUT api/books/
        [HttpPut]
        public async Task<ActionResult<Book>> Put(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            if (!db.Books.Any(x => x.Id == book.Id))
            {
                return NotFound();
            }
 
            db.Update(book);
            await db.SaveChangesAsync();
            return Ok(book);
        }
 
        // DELETE api/books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> Delete(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            db.Books.Remove(book);
            await db.SaveChangesAsync();
            return Ok(book);
        }
    }
}