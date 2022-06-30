using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.Paralelism
{
	internal class ThreadingStudy
	{
		List<string> resultado = new List<string>();
		public ThreadingStudy()
		{
			Stopwatch time1 = Stopwatch.StartNew();
			Thread t1 = new Thread(() => {
				int cont = 0;
				while (cont < 1000)
				{
					resultado.Add(Guid.NewGuid().ToString());
					for (int i = 0; i < 100; i++)
					{
						for (int j = 0; j < 100; j++)
						{
						resultado.Add(Guid.NewGuid().ToString() + "renan");

						}

					}
					cont++;
				}
			});

			Thread t2 = new Thread(() => {
				int cont = 0;
				while (cont < 1000)
				{
					resultado.Add(Guid.NewGuid().ToString());
					cont++;
				}
			});
			
			
			t1.Start();
			t2.Start();

			while(t1.IsAlive || t2.IsAlive)
			{

			}

			Console.WriteLine("finalizado...");
			Console.WriteLine("total segundos: " + time1.Elapsed.TotalSeconds);
			Console.WriteLine("total milisegundos: " + time1.Elapsed.TotalMilliseconds);
		}
		

	}
}
