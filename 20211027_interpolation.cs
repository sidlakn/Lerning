using System;

public class Program
{
	public static void Main()
	{
		string customerName = "Mr. Jones";
		string currentProduct = "Magic Yield";
		int currentShares = 2975000;
		decimal currentReturn = 0.1275m;
		decimal currentProfit = 55000000.0m;
		string newProduct = "Glorious Future";
		decimal newReturn = 0.13125m;
		decimal newProfit = 63000000.0m;
		
		Console.WriteLine("Here's a quick comparison:\n");
		string comparisonMessage = "";
		comparisonMessage += $"Dear {customerName}";
		comparisonMessage += "\n";
		comparisonMessage += $"As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return";
		comparisonMessage += "\n\n";
		comparisonMessage += $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P}";
		comparisonMessage += $"Our new product, Glorious Future offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C2}.";
		comparisonMessage += "\n\n";
		comparisonMessage += "Here's a quick comparison:";
		comparisonMessage += "\n\n";
		comparisonMessage += "Magic Yield".PadRight(20);
		comparisonMessage += $"{currentReturn:P}".PadRight(10);
		comparisonMessage += $"{currentProfit:N2}";
		comparisonMessage += "\n";
		comparisonMessage += "Glorious Future".PadRight(20);
		comparisonMessage += $"{newReturn:P}".PadRight(10);
		comparisonMessage += $"{newProfit:N2}";
		Console.WriteLine(comparisonMessage);
	}
}
