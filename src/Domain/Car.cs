using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Car //OCP sendo ferido IComparable<Car>
	{
		public decimal Price { get; set; }
		public string? Name { get; set; }
		
		//Compare ferindo o OCP
		//public int CompareTo(Car? other)
		//{
		//	return Name.ToUpper().CompareTo(other.Name.ToUpper());
		//}
	}
}
