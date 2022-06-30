using Microsoft.Extensions.DependencyInjection;

namespace r3nan.dojo.console.DependencyInjection
{
	public class DIContainer
	{
		public int Value1 { get;private set; }
		public int Value2 { get;private set; }

		public DIContainer()
		{
			Value1 = Random.Shared.Next(minValue: 1, maxValue: 100);
			Value2 = Random.Shared.Next(minValue: 1, maxValue: 100);
		}

		public void CreateServices()
		{

			//Adding service collection
			var serviceCollection = new ServiceCollection();
			//conf service
			serviceCollection.AddSingleton<DIContainer>();

			var serviceProvider = serviceCollection.BuildServiceProvider();
			var serviceProvider2 = serviceCollection.BuildServiceProvider();

			var service1 = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<DIContainer>();
			var service2 = serviceProvider.GetRequiredService<DIContainer>();
			var service3 = serviceProvider.GetRequiredService<DIContainer>();

			var service4 = serviceProvider2.CreateScope().ServiceProvider.GetRequiredService<DIContainer>();
			var service5 = serviceProvider2.GetRequiredService<DIContainer>();
			var service6 = serviceProvider2.GetRequiredService<DIContainer>();

			Console.WriteLine(service1.GetHashCode());
			Console.WriteLine(service2.GetHashCode());
			Console.WriteLine(service3.GetHashCode());
			Console.WriteLine(service4.GetHashCode());
			Console.WriteLine(service5.GetHashCode());
			Console.WriteLine(service6.GetHashCode());
		}
	}
}
