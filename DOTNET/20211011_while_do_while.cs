using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("while");
		int index = 200;
		while (index < 100)
		{
			Console.WriteLine(index);
			index++;
		}

		Console.WriteLine("for");
		for (int index2 = 0; index2 < 100; index2++)
		{
			Console.WriteLine(index2);
		}

		int index3 = 200;
		Console.WriteLine("do");
		do
		{
			Console.WriteLine(index3);
			index3++;
		}
		while (index3 < 100);
	}
}
