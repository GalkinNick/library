using library.Data.Interfaces;
using library.Data.Mocks;
using library.Data.Models;
using library.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace library.Pages
{
    public class BooksModel : PageModel
    {
       private readonly ILogger<BooksModel> _logger;

      

        private MockBooks _mock = new MockBooks();


        public BooksModel(ILogger<BooksModel> logger)
        {
            _logger = logger;
        }
        public IEnumerable<Book> BooksList()
        {
            return _mock.Books;
		}
        public void OnGet()
        {
        }
    }
}
