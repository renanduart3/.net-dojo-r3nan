using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.SOLID._3___Liskov_substitution
{
	// LISKOV SUBSTITUTION VIOLATION
	// IBirdsThatNotFly CAN'T SUBSTITUTE BIRDS
	public class RubberBird : IBirdsThatNotFly
	{
		public void Fly()
		{
			throw new NotImplementedException();
		}
	}
}
