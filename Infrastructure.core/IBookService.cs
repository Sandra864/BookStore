using Domain.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.core
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBook(string bookId);
        Book AddUpdateBook(Book book);
        void DeleteBook(string bookId);
    }
}
