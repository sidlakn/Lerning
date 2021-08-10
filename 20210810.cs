using System;

namespace MyNewApp
{
	public class Program
	{
		public static void Main()
		{
			Steam.Telegram();
			Console.WriteLine("Hello World");
			minecraft();
		}

		static void minecraft()
		{
			Console.WriteLine("minecraft");
		}
	}

	class Steam
	{
		public static void Telegram()
		{
			Console.WriteLine("Telegram");
		}
	}
}
