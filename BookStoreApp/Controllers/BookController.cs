using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookDataLayer;

namespace BookStoreApp.Controllers
{
    public class BookController : ApiController
    {
        public BookController()
        {
            BookStorage = BookStorage.GetBookStorage();
        }

        private BookStorage BookStorage { get; }

        // GET api/values
        public IEnumerable<Book> Get()
        {
            return BookStorage.GetBooks();
        }

        // GET api/values/5
        public Book Get(int id)
        {
            return BookStorage.GetBookById(id);
        }

        // POST api/values
        public bool Post([FromBody] Book book)
        {
            return BookStorage.AddBook(book);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            BookStorage.RemoveBookById(id);
        }
    }
}
