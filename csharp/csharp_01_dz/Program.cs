using System;

namespace csharp_01_dz
{
	internal class Program
	{
		class task01
		{
			public void task()
			{
				string line = "";
				int counter = 0;
				while (line != ".")
				{ 
					line = Console.ReadLine();
					if (line == " ")
					{
						counter++;
					}
				}
				Console.WriteLine("Number of spaces: " + counter);
			}
		};

		class task02 
		{
			public void task()
			{
				string number = "";
				while (number.Length < 6 || number.Length > 6)
				{
					Console.Write("Enter 6-digital number: ");
					number = Console.ReadLine();
				}

				int sum1 = 0;
				for (int i = 0; i < 3; i++)
					sum1 += Convert.ToInt32(number[i]);

				int sum2 = 0;
				for (int i = 3; i < 6; i++)
					sum2 += Convert.ToInt32(number[i]);

				Console.WriteLine("Sum of first 3 digits = " + sum1 + "\n" + "Sum of last 3 digits = " + sum2);
				if (sum1 == sum2)
					Console.WriteLine("LUCKY TICKET!");
				else
					Console.WriteLine("Next time...");
			}
		}

		class task03
		{
			public void task()
			{ 
				int a = 0,  b = 0;

				Console.Write("Enter a: ");
				a = Int32.Parse(Console.ReadLine());

				Console.Write("Enter b: ");
				b = Int32.Parse(Console.ReadLine());

				for (int i = a; i <= b; i++)
				{
					for (int j = 0; j < i; j++)
					{
						Console.Write(i);
					}
					Console.WriteLine();
				}
			}
		}

		class task04
		{
			public void task()
			{
				Console.Write("Enter number to reverse: ");
				int n = Int32.Parse(Console.ReadLine());
				string s = n.ToString();
				string rs = string.Empty;

				for (int i = s.Length - 1; i >= 0; i--)
				{
					rs += s[i];
				}
				Console.WriteLine("Reverse of " + s + " is " + rs);
			}
		}

		static void Main(string[] args)
		{
			task04 task04 = new task04();
			task04.task();
		}
	}
}
