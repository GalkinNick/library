using library.Data.Models;


namespace library.DataAccess.Entites
{
	public class BookEntity
	{
		public int id { set; get; }
		public string name { set; get; }
		public double price { set; get; }
		public string shortDesc { set; get; }
		public string img { set; get; }
		public int categoryID { set; get; }
		public virtual Category Category { set; get; }
	}
}
