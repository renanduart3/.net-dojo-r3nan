using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Book
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public List<Author> Authors { get; set; }
		public DateTime PublishDate { get; set; }

		public Book()
		{
			Authors = new List<Author>();
		}
	}
}
