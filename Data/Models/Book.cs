using library.Data.Interfaces;
using System.Globalization;

namespace library.Data.Models
{
    public class Book
    {
		public int id { set; get; }
        public string name { set; get; }
        public double price { set; get; }
        public string shortDesc { set; get; }
        public string img { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }


		private Book(int Id, string name, double price, string shortDesc, Category category)
		{
			id = Id;
			name = name;
			this.price = price;
			this.shortDesc = shortDesc;
			this.Category = category;
		}

		public static (Book book, string error) Create (int Id, string name, double price, string shortDesc, Category category)
		{

			var error = string.Empty;

			if (string.IsNullOrEmpty(name))
			{
				error = "Error";
			}


			var book = new Book(Id, name, price, shortDesc, category);

			return (book, error);
		}


	}
}
