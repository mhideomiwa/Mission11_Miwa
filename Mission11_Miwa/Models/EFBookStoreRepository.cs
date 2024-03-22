namespace Mission11_Miwa.Models;

public class EfBookStoreRepository : IBookStoreRepository
{
    private BookStoreContext _context;
    
    public EfBookStoreRepository(BookStoreContext context)
    {
        _context = context;
    }
    
    public IQueryable<BookStore> Books => _context.Books;
}