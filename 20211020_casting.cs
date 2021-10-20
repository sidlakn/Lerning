using System;

public class Program
{
	public static void Main()
	{
		int value1 = 12;
		decimal value2 = 6.2m;
		float value3 = 4.3f;
		
		int cucumber = (int)value2;
		int result1 = value1 / cucumber;
		Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
		
		decimal banana = (decimal)value3;
		decimal result2 = value2 / banana;
		Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
		
		float result3 = value3 / value1;
		Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
	}
}
