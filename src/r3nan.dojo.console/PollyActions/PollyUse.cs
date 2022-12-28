using System;
using System.Net.Http;
using System.Threading.Tasks;
using Polly.Retry;
using Polly;
using Microsoft.Extensions.DependencyInjection;

namespace r3nan.dojo.console.PollyActions
{
	public class PollyUse
	{
		private ServiceCollection ConfigureServices(ServiceCollection services)
		{
			services.AddHttpClient("r3nan", opt =>
				opt.BaseAddress = new Uri("http://localhost:5178/api/PollyTest/"))
				.AddPolicyHandler(new ClientPolicy().LinearHttpRetry
				);

			return services;
		}

		public async Task MakeARequest()
		{
			var serviceCollection = new ServiceCollection();
			var config = ConfigureServices(serviceCollection);
			var services = config.BuildServiceProvider();
			var hhtpFactory = services.GetRequiredService<IHttpClientFactory>();
			var client = hhtpFactory.CreateClient(name:"r3nan");
			//100, more probability to get success than 1
			var response = await client.GetAsync("70");

			response.EnsureSuccessStatusCode();

			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("--> ResponseService returned a Success");
			}
			else
			{
				Console.WriteLine("--> ResponseService returned a Failure");
			}
		}
	}

	public class ClientPolicy
	{
		public AsyncRetryPolicy<HttpResponseMessage> ImmediateHttpRetry { get; }
		public AsyncRetryPolicy<HttpResponseMessage> LinearHttpRetry { get; }
		public AsyncRetryPolicy<HttpResponseMessage> ExponentialHttpRetry { get; }

		public ClientPolicy()
		{
			ImmediateHttpRetry = Policy.HandleResult<HttpResponseMessage>(
				res => !res.IsSuccessStatusCode)
				.RetryAsync(10);

			LinearHttpRetry = Policy.HandleResult<HttpResponseMessage>(
				res => !res.IsSuccessStatusCode)
				.WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(3));

			ExponentialHttpRetry = Policy.HandleResult<HttpResponseMessage>(
				res => !res.IsSuccessStatusCode)
				.WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
		}
	}
}
