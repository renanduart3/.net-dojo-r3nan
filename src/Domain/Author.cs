using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Author
	{
		public int AuthorId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<Book> Books { get; set; }

		public Author()
		{
			Books = new List<Book>();
		}
	}
}
