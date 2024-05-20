using library.Data.Interfaces;
using library.Data.Models;

namespace library.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories
        {
            get{
                return new List<Category>
                {
                    new Category{ categoryName = "Детектив"},
                    new Category{ categoryName = "Роман"},
                    new Category{ categoryName = "Фантастика"}
                };

            }
        }
    }
}
