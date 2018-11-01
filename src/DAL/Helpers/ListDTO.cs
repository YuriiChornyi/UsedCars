using System.Collections.Generic;

namespace DAL.Helpers
{
	public class ListDto<T>
	{
		public IEnumerable<T> Items;
		public int Count;
	}
}
