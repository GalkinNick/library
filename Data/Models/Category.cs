namespace library.Data.Models
{
    /// <summary>
    /// Класс для описания жанра книг
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public List<Book> books { get; set;}
    }

}
