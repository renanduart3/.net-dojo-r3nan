using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.Lambda_LINQ
{
	internal class LambdaAndLINQ
	{
		private List<Car> cars = new List<Car>();
		public LambdaAndLINQ()
		{
			cars.Add(new Car() { Name = "Mustang", Price = 12500.00M });
			cars.Add(new Car() { Name = "Ferrari", Price = 13500.00M });
			cars.Add(new Car() { Name = "McLaren", Price = 1500.00M });
			cars.Add(new Car() { Name = "Volvo", Price = 11500.00M });
			cars.Add(new Car() { Name = "Impala", Price = 20500.00M });
		}

		void ImplementingDelegates()
		{
			#region [Delegates Implementation]

			// Predicate
			//With a method
			cars.RemoveAll(Teste);
			//With an instance of a Predicate
			Predicate<Car> pred = (c) => c.Price > 10;
			//Without method with direct action
			cars.RemoveAll(c => c.Price > 10);

			//Action
			//With a method
			cars.ForEach(UpdatePrice);
			//With an instance of a Action
			Action<Car> action = UpdatePrice;
			cars.ForEach(action);
			//Without method with direct action
			cars.ForEach(p => p.Price += p.Price * 0.2M);

			//Func
			//With an instance of a Function
			Func<Car, string> func = (car) => car.Name = string.Concat("_test");
			List<string> newCarList = cars.Select(func).ToList();
			//With a method
			List<string> newCarList2 = cars.Select(AppendName).ToList();
			newCarList.ForEach((c) => Console.WriteLine(c));
			newCarList2.ForEach((c) => Console.WriteLine(c));

			#endregion
		}
		void SortAndComparisonImplementation()
		{
			//order by implementing Sort with lambda without IComparer on type.
			//cars.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

			//order by already do the job
			var result = cars.OrderBy(x => x.Price);
			var result2 = cars.OrderByDescending(x => x.Price);

			foreach (var item in cars)
			{
				Console.WriteLine($"Name: {item.Name} - Price: {item.Price}");
			}

			foreach (var item in result)
			{
				Console.WriteLine($"Name: {item.Name} - Price: {item.Price}");
			}

			foreach (var item in result2)
			{
				Console.WriteLine($"Name: {item.Name} - Price: {item.Price}");
			}

			

		}

		#region [Delegates]

		//Predicate -> return bool
		public bool Teste(Car car)
		{
			return car.Price > 10000;
		}

		//Action -> void
		void UpdatePrice(Car c)
		{
			c.Price += c.Price * 0.2M;
		}

		//Func -> return value TResult
		public string AppendName(Car c)
		{
			return c.Name = string.Concat("_test");
		}

		#endregion


		#region [LINQ]

		public void testLINQ()
		{

			Category c1 = new Category(1, "Tools", Tier.Mid);
			Category c2 = new Category(2, "Paper", Tier.Low);
			Category c3 = new Category(3, "Electronics", Tier.High);

			List<Product> products = new List<Product>()
			{
			  new Product(1,"Computer", 3150.50M,c1),
			  new Product(2,"Paper A4", 12.45M,c2),
			  new Product(3,"Pen", 2,c2),
			  new Product(4,"Hammer", 22.52M,c1),
			  new Product(5,"Monkey Wrench",41.70M,c1),
			  new Product(6,"TV", 2219.50M,c3),
			  new Product(7,"Saw", 12.50M,c1),
			  new Product(8,"Lamp", 1.50M,c3),
			  new Product(9,"Pliers", 2.80M,c1),
			  new Product(10,"Scissors", 4.60M,c2),
			  new Product(11,"LED", 0.20m,c3),
			};


			//FilterTierAndPrice(products);
			//FilterProductName(products);

		}

		void FilterProductName(List<Product> products)
		{
			//products that starts with P and anonymous
			var result2 = products
							.Where(p => p.Name.StartsWith("P"))
							.Select(p => new { p.Name, p.Price });
			Console.WriteLine("Products starting with P in a new object:");

			foreach (var item in result2)
			{
				Console.WriteLine(item.Name + " - " + item.Price);
			}
		}

		void FilterTierAndPrice(List<Product> products)
		{
			//all products tier 1 and price above 900
			var result = products.Where(x => x.Price < 900 && x.Category.Layer.Equals(Tier.High));
			foreach (var item in result)
			{
				Console.WriteLine($" Product: {item.Name} - Price {item.Price} - Tier : {item.Category.Name} ");
			}
		}

		#endregion

	}
}
