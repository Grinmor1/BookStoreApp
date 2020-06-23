using System.Collections.Concurrent;
using System.Collections.Generic;

namespace BookDataLayer
{
    public class BookStorage
    {
        private static BookStorage _bookStorage;
        private BookStorage()
        {
            Books = new ConcurrentDictionary<int, Book>
            {
                [1] = new Book {Author = "Conan Doyle", Name = "Sherlock Holmes", NumberPages = 740, Rating = 4.7},
                [2] = new Book
                    {Author = "Ernest Hemingway", Name = "The Old Man and the Sea", NumberPages = 461, Rating = 4.9},
                [3] = new Book
                {
                    Author = "Agatha Christie", Name = "The Mysterious Affair at Styles", NumberPages = 740,
                    Rating = 4.7
                },
                [4] = new Book {Author = "William Shakespeare", Name = "Hamlet", NumberPages = 1456, Rating = 4.6}
            };
        }

        public static BookStorage GetBookStorage()
        {
            return _bookStorage ?? (_bookStorage = new BookStorage());
        } 

        private ConcurrentDictionary<int, Book> Books { get; set; }

        public IEnumerable<Book> GetBooks()
        {
            return Books.Values;
        }

        public Book GetBookById(int bookId)
        {
            return Books[bookId];
        }

        public bool AddBook(Book book)
        {
            return Books.TryAdd(book.Id, book);
        }

        public void RemoveBookById(int bookId)
        {
            Books.TryRemove(bookId, out _);
        }
    }
}