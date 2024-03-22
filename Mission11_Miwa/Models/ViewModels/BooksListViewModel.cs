namespace Mission11_Miwa.Models.ViewModels;

public class BooksListViewModel
{
    public IQueryable<BookStore> Book { get; set; }

    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
}