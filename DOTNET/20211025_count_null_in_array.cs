using System;

public class Program
{
	public static void Main()
	{
		string[] banana = {null, "nazar", "andriy", "dima", null};
		foreach (string person in banana)
		{
			Console.WriteLine(person);
		}

		int count = 0;
		foreach (string person in banana)
		{
			if (person == null)
			{
			    count ++ ;
			}
		}
		Console.WriteLine(count);
	}
}
