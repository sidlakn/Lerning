using System;

public class Program
{
	public static void Main()
	{
		int heroesHealth = 10;
		int monsterHealth = 10;
		Random random = new Random();
		int damage = 0;
		bool isHeroTurn = true;
		do
		{
			damage = random.Next(1, 11);
			if (isHeroTurn)
			{
				monsterHealth = monsterHealth - damage;
				Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
				isHeroTurn = false;
			}
			else
			{
				heroesHealth = heroesHealth - damage;
				isHeroTurn = true;
				Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroesHealth} health.");
			}

			Console.WriteLine("turn finished");
		}
		while (monsterHealth > 0 && heroesHealth > 0); 
	}
}
