using Domain;
using Microsoft.EntityFrameworkCore;

namespace r3nan.dojo.console.Databases
{
	public class EFInMemoryAccess:DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("DbEFCoreInMemory");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>().HasData(
					new Book { BookId = 1 , Title = "Salamandra" , PublishDate = DateTime.Now },
					new Book { BookId = 2, Title = "Salamandra2" , PublishDate = DateTime.Now },
					new Book { BookId = 3, Title = "Salamandra3" , PublishDate = DateTime.Now }
					
				);
			modelBuilder.Entity<Author>().HasData(
					new Author { AuthorId = 1, FirstName = "Jackson", LastName = "Potter" },
					new Author { AuthorId = 2, FirstName = "Jackson1", LastName = "Potter1" },
					new Author { AuthorId = 3, FirstName = "Jackson2", LastName = "Potter2" }
				);
		}
	}
}
