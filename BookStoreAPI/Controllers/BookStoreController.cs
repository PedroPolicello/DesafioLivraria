using BookStoreAPI.Communication.Requests;
using BookStoreAPI.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookStoreController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateBook), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] RequestCreateBook request)
    {
        var book = new Book
        {
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price,
            AmoutInStock = 1
        };

        ResponseCreateBook response = new ResponseCreateBook
        {
            BookObj = book,
        };

        return Created(string.Empty, response);
    }


    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        var response = new List<Book>()
        {
            new Book { Id = 1, Title = "The Big Boss", Author = "Pedro Policello", Genre = Genres.Mystery, Price = 10.98, AmoutInStock = 1 },
            new Book { Id = 2, Title = "Waves", Author = "Pedro Policello", Genre = Genres.Poetry, Price = 7.99, AmoutInStock = 1 }
        };

        return Ok(response);
    }


    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult EditBookInfo([FromBody] RequestCreateBook request)
    {
        return NoContent();
    }


    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook()
    {
        return NoContent();
    }
}
