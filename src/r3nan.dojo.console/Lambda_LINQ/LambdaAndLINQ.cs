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

	}
}
