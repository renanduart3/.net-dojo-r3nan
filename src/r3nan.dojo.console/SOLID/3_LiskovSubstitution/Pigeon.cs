using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.SOLID._3___Liskov_substitution
{
	// LISKOV SUBSTITUTION VIOLATION
	// CHICKENS CAN'T SUBSTITUTE BIRDS
	internal class Pigeon : IBirdsThatFly
	{
		public void Fly()
		{
			Console.WriteLine("Flying");
		}
	}

}
