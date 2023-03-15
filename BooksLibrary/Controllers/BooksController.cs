using BooksLibrary.Core.Entities;
using BooksLibrary.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BooksLibrary.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public async Task<IActionResult> GetBooksList()
        {
            try
            {
                var result = await _bookService.GetBooksList();
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(book);
            }
            try
            {
                var result = await _bookService.AddNewBook(book);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
