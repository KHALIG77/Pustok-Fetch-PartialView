using Microsoft.EntityFrameworkCore;
using PustokStart.Models;

namespace PustokStart.DAL
{
    public class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options):base(options)
        {
            
        }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }  
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<BookTags> BookTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Feature>Features { get; set; }

    }
}
