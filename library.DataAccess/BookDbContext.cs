using library.Data.Models;
using library.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace library.DataAccess
{
	public class BookDbContext : DbContext
	{
		public BookDbContext(DbContextOptions<DbContext> options) : base(options) { 
			Database.EnsureCreated();
		}

		public DbSet<BookEntity> Books { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BookEntity>().HasData(
				new BookEntity { id = 1, name = "First", price = 150, shortDesc = "", img = " ", categoryID = 1 }
				);
		}

	}
}
