using libreriaa_SLE.Data.Services;
using libreriaa_SLE.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libreriaa_SLE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksServicecs _booksService;

        public BooksController(BooksServicecs booksServicecs)
        {
            _booksService = booksServicecs;
        }


        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allbooks = _booksService.GetAllBks();
            return Ok(allbooks);
        }


        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _booksService.GetBooksById(id);
            return Ok(book);
        }


        [HttpPost("add-book")]
        public  IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);

            return Ok();
        }



    }
}
