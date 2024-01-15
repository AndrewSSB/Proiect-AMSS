using Microsoft.AspNetCore.Mvc;
using BookHub.BLL.Interfaces;
using BookHub.Services.Models;
using BookHub.Services.Interfaces;
using System.Threading.Tasks;

namespace BookHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class BookController : ControllerBase
    {
        private readonly IBookManager manager;
        public BookController(IBookManager bookManager)
        {
            this.manager = bookManager;
        }

        //add a book (admin)
        [HttpPost("Add_Book_Admin")]
        public async Task<IActionResult> AddBook([FromBody] BookModel bookModel)
        {
            manager.AddBook(bookModel);
            return Ok();
        }

        //get all books
        [HttpGet("Get_All_Books")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = manager.GetAllBooks();
            return Ok(books);
        }

        //get a book by name
        [HttpGet("Get_Book_by_{title}")]
        public async Task<IActionResult> GetBook([FromRoute] string title)
        {
            var book = manager.GetBook(title);
            return Ok(book);
        }

        //get book recommendations (for home page)
        [HttpGet("Get_Book_recommendations")]
        public async Task<IActionResult> GetBookRecommendations()
        {
            var books = manager.GetBookRecommendations();
            return Ok(books);
        }
    }
}
