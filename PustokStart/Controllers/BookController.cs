
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokStart.DAL;
using PustokStart.Models;

namespace PustokStart.Controllers
{
    public class BookController:Controller
    {
        public readonly PustokContext _context;
        public BookController(PustokContext context)
        {
            _context= context;
        }
        public IActionResult GetBookDetail(int id)
        {
            Book book =_context.Books.Include(x=>x.Author).Include(x=>x.BookImages).Include(x=>x.Tags).ThenInclude(x=>x.Tag).FirstOrDefault(x=>x.Id==id);
            if (book == null) StatusCode(404);

          return PartialView("_BookModalPartial",book);
        }
    }
}
