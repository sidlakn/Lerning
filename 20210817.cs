using System;

public class Program
{
	public static void Main()
	{
		// SKU = Stock Keeping Unit
		string sku = "02-MN-S";
		string[] product = sku.Split('-');
		string type = "";
		string color = "";
		string size = "";
		switch (product[0])
		{
			case "01":
				type = "Sweat shirt";
				break;
			case "02":
				type = "T-Shirt";
				break;
			case "03":
				type = "Sweat pants";
				break;
		}

		switch (product[1])
		{
			case "BL":
				color = "Black";
				break;
			case "MN":
				color = "Maroon";
				break;
		}

		switch (product[2])
		{
			case "S":
				size = "Small";
				break;
			case "M":
				size = "Medium";
				break;
			case "L":
				size = "Large";
				break;
		}

		Console.WriteLine($"Product: {size} {color} {type}");
	}
}
