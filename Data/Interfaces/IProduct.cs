using library.Data.Models;

namespace library.Data.Interfaces
{
    public interface IProduct
    {
      IEnumerable<Book> Books { get; }
      Book GetBook(int bookId);
    }
}
