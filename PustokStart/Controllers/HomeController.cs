using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokStart.DAL;
using PustokStart.ViewModels;



namespace PustokStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _context;

        public HomeController(PustokContext context)
        {
            _context = context; 
        }

       
       
        public IActionResult Index() {
            HomeViewModel vm = new HomeViewModel(); 
            vm.FeaturedBooks= _context.Books.Include(x=>x.Author).Include(x => x.BookImages).Where(x=>x.IsFeatured==true).Take(10).ToList();
            vm.NewBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.IsNew == true).Take(10).ToList();
            vm.DiscountedBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.DiscountPerctent>0).Take(10).ToList();
            vm.Slides = _context.Slides.ToList();
            vm.Features = _context.Features.ToList();
            


            return View(vm);
        }
        
    }
}