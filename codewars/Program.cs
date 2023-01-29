using System.Threading;

namespace codewars
{
	internal class Program
	{
		//public static string ToCamelCase(string str)
		//{	
		//	char[] cstr = str.ToCharArray();

		//	str = "";
		//	for (int i = 0; i < cstr.Length; i++)
		//	{
		//		if (cstr[i] == '-' || cstr[i] == '_')
		//		{
		//			cstr[i+1] = Char.ToUpper(cstr[i+1]);
		//			continue;
		//		}
		//		str += cstr[i].ToString();
		//	}
		//	return str;
		//}

		//public static int StringToNumber(String str)
		//{
		//	return Convert.ToInt32(str);
		//}


		public static bool ValidatePin(string pin)
		{
			bool flag = false;
			if (pin.Length == 4 || pin.Length == 6)
			{
				for (int i = 0; i < pin.Length; i++)
				{
					if (Char.IsSymbol(pin[i]))
						flag = false;
					else
						flag = true;
				}
			}
			else
				flag = false;

			return flag;
		}


		static void Main(string[] args)
		{
			
		}
	}
}