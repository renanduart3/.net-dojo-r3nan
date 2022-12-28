using Domain;
using Microsoft.EntityFrameworkCore;

namespace r3nan.dojo.console.Databases
{
	public class EntityFrameworkAccess : DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlite("Data Source=lib.db");
			optionsBuilder.UseSqlServer(@"Data Source=LION-HEART\SQLEXPRESS;Initial Catalog=EfCoreDb;User Id=sa;Password=12345;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		}
	}
}
