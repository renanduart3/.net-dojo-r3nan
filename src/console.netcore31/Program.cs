using classlib.netstandard;
using System;

namespace console.netcore31
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Doenst work
			//Car c1 = new Car();
			string s = null;
			CarStandard c2 = new CarStandard();
			c2.Name = s ?? "Hello";
			//if (c2.Name is not null)
			if (c2.Name != null)
			{

			}
			Console.WriteLine("Hello World!");
		}
	}
}
