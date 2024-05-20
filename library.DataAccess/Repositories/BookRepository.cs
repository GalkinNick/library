

using library.Data.Models;
using library.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace library.DataAccess.Repositories
{
	public class BookRepository : IBookRepository
	{

		private readonly BookDbContext _context;

		public BookRepository(BookDbContext context)
		{
			_context = context;
		}

		public async Task<List<Book>> Get()
		{
			var bookEntity = await _context.Books
				.AsNoTracking()
				.ToListAsync();

			var books = bookEntity
				.Select(b => Book.Create(b.id, b.name, b.price, b.shortDesc, b.Category).book).
				ToList();

			return books;
		}

		public async Task<int> Create(Book book)
		{
			var bookEntity = new BookEntity
			{
				id = book.id,
				name = book.name,
				price = book.price,
				shortDesc = book.shortDesc,
				Category = book.Category,

			};

			await _context.Books.AddAsync(bookEntity);
			await _context.SaveChangesAsync();

			return bookEntity.id;
		}

		public async Task<int> Update(int id, string name, double price, string shortDesc, Category category)
		{
			await _context.Books
			   .Where(b => b.id == id)
			   .ExecuteUpdateAsync(s => s
			   .SetProperty(b => b.name, b => name)
			   .SetProperty(b => b.price, b => price)
			   .SetProperty(b => b.shortDesc, b => shortDesc)
			   .SetProperty(b => b.Category, b => category));

			return id;
		}

		public async Task<int> Delete(int id)
		{
			await _context.Books
				.Where(b => b.id == id)
				.ExecuteDeleteAsync();

			return id;
		}
	}
}
