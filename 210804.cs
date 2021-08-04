using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Skype();
		Discord(9, "2");
	}

	static void Skype()
	{
		Console.WriteLine("Skype");
	}

	static void Discord(int viber, string parameter2)
	{
		Console.WriteLine(viber);
		Console.WriteLine(parameter2);
	}
}
