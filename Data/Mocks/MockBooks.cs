using library.Data.Interfaces;
using library.Data.Models;

namespace library.Data.Mocks
{
    public class MockBooks : IProduct
    {
        private readonly ICategory _category = new MockCategory();

        public IEnumerable<Book> Books { 
            get
            {
                return new List<Book>
                {
                    /*new Book {
                        name = "Обломов",
                        shortDesc = "",
                        img = "/img/Oblomov.jpeg",
                        price = 1000,
                        Category = _category.AllCategories.First()
                    },
                     new Book {
                        name = "Герой нашего времени",
                        shortDesc = "",
                        img = "/img/Hero.jpeg ",
                        price = 2000,
                        Category = _category.AllCategories.Last() 
                    },
                     new Book {
                        name = "Война и мир",
                        shortDesc = "",
                        img = "/img/War.jpeg",
                        price = 2500,
                        Category = _category.AllCategories.First()
                    }
					 ,
					 new Book {
						name = "Яма",
						shortDesc = "",
						img = "/img/Iama.jpg",
						price = 4500,
						Category = _category.AllCategories.Last()
					}*/
				};
            }
        }

        public Book GetBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
