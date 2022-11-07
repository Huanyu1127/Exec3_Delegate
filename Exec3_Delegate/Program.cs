using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 1, 9, 11, 22, 14, 18 };

			Func<int, bool> func = n1 => n1 % 2 == 1;

			List<int> items2 = GetEvenItems(items, func);
			foreach(int item in items2)
			{
				Console.WriteLine(item);
			}
		}
		public static List<int> GetEvenItems(List<int> value,Func<int,bool> func)
		{
			List<int> items = new List<int>();
			foreach (int item in value)
			{
				if (func(item)) items.Add(item);
			}
			return items;
		}
	}
	
}
