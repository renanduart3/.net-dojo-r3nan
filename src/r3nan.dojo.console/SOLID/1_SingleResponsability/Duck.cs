using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.SOLID._1___Single_Responsability
{
	public class Duck
	{
		string? Name { get; set; }
		string? Description { get; set; }

		public string MakeSound()
		{
			return "Quack!";
		}

		// SINGLE RESPONSABILITY VIOLATION
		public string WrongMakeSound()
		{
			if (true)
			{
				Fly();
				Name = "Name changed";
			}

			return "Quack"!;
		}
		public void Fly()
		{

		}
	}
}
