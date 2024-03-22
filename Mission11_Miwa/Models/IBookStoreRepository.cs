namespace Mission11_Miwa.Models;

public interface IBookStoreRepository
{
    IQueryable<BookStore> Books  { get; }
}