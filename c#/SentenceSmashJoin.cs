// join a string array together into a sentence

using System;

public class SentenceSmashJoin
{

	public static string Smash(string[] words) => string.Join(" ", words);

	public static void Main(string[] args)
	{
		Console.WriteLine(Smash(new string[] {"What", "about", "this"})); // What about this
	}
}