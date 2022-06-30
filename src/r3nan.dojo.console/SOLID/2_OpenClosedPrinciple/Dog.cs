using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r3nan.dojo.console.SOLID._2___Open_Closed_Principle
{
	//Req. For dumb (mute dogs) dogs, they dont make sounds
	public class Dog : IDog
	{
		public string? Name { get; set; }
		public string? Description { get; set; }

		//wrong property purpose
		public Dogtype DogType { get; set; }

		public string MakeSound()
		{
			return "Wuf!";
		}
		public string WrongMakeSound()
		{
			if (DogType.Equals(Dogtype.Dumb))
				return "---";
			return "Wuf!";
		}
	}
	//wrong enum purpose
	public enum Dogtype
	{
		Dumb,
		NotDumb,
		Loud
	}
}
