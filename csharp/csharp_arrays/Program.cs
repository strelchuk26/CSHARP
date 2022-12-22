using System;
using System.Collections.Generic;

namespace csharp_arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();

			int[] array = new int[5];

			Random r = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = r.Next(100, 1000);
				Console.WriteLine("[" + (i + 1) + "]" + " Element: " + array[i]);
			}

			for (int i = 0; i < 10; i++)
			{
				list.Add(r.Next(10, 100));
			}

			Console.Write("List of random nubers: ");

			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i] + " ");
			}
		}
	}
}
