using System;

public class Program
{
	public static void Main()
	{
		string[] values = {"12.3", "45", "ABC", "11", "DEF"};
		double sum = 0;
		string sum3 = "";
		foreach (string value in values)
		{
			double result = 0;
			if (double.TryParse(value, out result))
			{
				sum += result;
			}
			else
			{
				sum3 += value;
			}
		}

		Console.WriteLine(sum3);
		Console.WriteLine(sum);
	}
}
