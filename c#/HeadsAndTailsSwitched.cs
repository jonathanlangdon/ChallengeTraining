// re-arrange heads and tails of animals

using System;

public class HeadsAndTailsSwitched
{
	public static string[] FixTheMeerkat(string[] arr)
	{
		Array.Reverse(arr);
		return arr;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", FixTheMeerkat(new string[] {"tail", "body", "head"}))); // "head", "body", "tail"
	}
}