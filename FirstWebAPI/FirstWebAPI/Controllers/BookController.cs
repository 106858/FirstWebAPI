using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Controllers;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        
        static List<Book> BookList = new List<Book>();
        [HttpGet]
        public List<Book> GetBooks()
        {
           
            for (int i = 0; i < 5; i++)
            {
                Book book = new Book();
                book.BookID = i;
                book.Title = "Atomic Habits" + i;
                book.Cost = i * 100;
                book.AuthorName = "Author " + i;
                BookList.Add(book);
                
            }
                return BookList;
            
        }
        [HttpPost]
        public int AddBook(Book book)
        {
            BookList.Add(book);
            return 1;
        }
        
    }
}
