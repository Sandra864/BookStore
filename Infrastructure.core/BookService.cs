using Domain.core;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.core
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _books;
        public BookService(IDbClient dbClient)
        {
            _books = dbClient.GetBookCollection();
        }

        public Book AddUpdateBook(Book book)
        {

            if (string.IsNullOrEmpty(book.Id))
                _books.InsertOne(book);
            else
            {
                var bookAlreadyExist = _books.Find(x => x.Id == book.Id).FirstOrDefault();
                if (bookAlreadyExist != null)
                    _books.ReplaceOne(x => x.Id == bookAlreadyExist.Id, book);
            }
            return book;
        }

        public List<Book> GetBooks()
        {
            return _books.Find(book => true).ToList();
        }

        public Book GetBook(string bookId)
        {
            var bookExist = _books.Find(x => x.Id == bookId).FirstOrDefault();
            return bookExist;
        }

        public void DeleteBook(string bookId)
        {
            _books.DeleteOne(x => x.Id == bookId);
        }
    }
}
