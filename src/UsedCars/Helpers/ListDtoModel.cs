using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedCars.Helpers
{
	public class ListDtoModel<T>
	{
		public IEnumerable<T> Items;
		public int Count;
	}
}
