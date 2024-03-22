using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11_Miwa.Models;
using Mission11_Miwa.Models.ViewModels;

namespace Mission11_Miwa.Controllers;

public class HomeController : Controller
{
    private IBookStoreRepository _repository;

    public HomeController(IBookStoreRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index(int pageNum)
    {
        int pageSize = 10;

        var pageData = new BooksListViewModel
        {
            Book = _repository.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = pageSize,
                TotalItems = _repository.Books.Count()
            }
        };
        
        
        return View(pageData);
    }
}