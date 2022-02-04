using System;

public class Program
{
	public static void Main()
	{
		string pangram = "The quick brown fox jumps over the lazy dog";
		string[] words = pangram.Split(' ');
		foreach (string word in words)
		{
			//Console.WriteLine(word);
			char[] letters = word.ToCharArray();
			Array.Reverse(letters);
			Console.WriteLine(letters);
		}
	}
}
