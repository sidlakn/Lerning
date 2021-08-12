using System;
using MyOldApp;

namespace MyNewApp
{
	public class Program
	{
		public static void Main()
		{
			Nazar.Chrome();
			Console.WriteLine("Hello Dmutruk");
		}
	}
}

namespace MyOldApp
{
	class Nazar
	{
		public static void Chrome()
		{
			Console.WriteLine("nice code?");
			
		}
	}
}
