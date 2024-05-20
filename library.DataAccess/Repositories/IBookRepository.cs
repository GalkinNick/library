using library.Data.Models;


namespace library.DataAccess.Repositories
{
	public interface IBookRepository
	{
		Task<int> Create(Book book);
		Task<int> Update(int id, string name, double price, string shortDesc, Category category);
		Task<int> Delete(int id);
		Task<List<Book>> Get();
	}
}
