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

        [HttpPost("add-book")]
        public  IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);

            return Ok();
        }



    }
}
