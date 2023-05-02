using BookInfo.Models;
using Microsoft.EntityFrameworkCore;

namespace BookInfo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
