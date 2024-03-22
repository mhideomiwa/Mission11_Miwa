using Microsoft.EntityFrameworkCore;

namespace Mission11_Miwa.Models;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
    {
    }
    
    public DbSet<BookStore> Books { get; set; }
}