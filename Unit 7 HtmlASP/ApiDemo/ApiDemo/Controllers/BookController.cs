using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiDemo.Models;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //api/Book/add?title=CatAndThehat&category=childs
        [HttpPost("add")]
        public Book AddBook(string title, string category)
        {
            return Book.AddBook(title, category);
        }

        //api/Book
        [HttpGet()]
        public List<Book> GetAll()
        {
            return Book.GetAll();
        }

        //api/Book/{id}
        //api/Book/1           api/Book/3
        [HttpGet("{id}")]
        public Book getById(int id)
        {
            return Book.FindById(id);
        }

        //api/Book/category/{catname}
        //api/Book/category/childs     api/Book/category/fantasy
        [HttpGet("category/{catname}")]
        public List<Book> getByCategory(string catname)
        {
            return Book.FindByCategory(catname);
        }
    }
}
