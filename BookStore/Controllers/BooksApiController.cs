using Domain.core;
using Infrastructure.core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksApiController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksApiController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var result = _bookService.GetBooks();
            return Ok(result);
        }

        [HttpGet("{Id}", Name = "GetBook")]
        public IActionResult GetBook(string Id)
        {
            var result = _bookService.GetBook(Id);
            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPost]
        [HttpPut]
        public IActionResult AddUpdateBook(Book book)
        {
            var result = _bookService.AddUpdateBook(book);
            return Ok(result);
        }

        [HttpDelete("{Id}", Name = "DeleteBook")]
        public IActionResult DeleteBook(string Id)
        {
            _bookService.DeleteBook(Id);
            return NoContent();
        }
    }
}
