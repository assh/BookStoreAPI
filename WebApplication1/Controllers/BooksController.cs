using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using BookstoreAPI.Models;
using BookStore.data.Models;
using BookStore.data.Interfaces;
using BookStore.data.Repo;

namespace BookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private IBookRepo books = new BookRepo();
        [HttpGet]

        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }

        [HttpGet("{id}")]

        public ActionResult<Book> GetBook(int id)
        {
            //var book =  books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
