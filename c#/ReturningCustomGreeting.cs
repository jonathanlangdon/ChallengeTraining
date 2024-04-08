// return a custom greeting based on input name

using System;

public class ReturningCustomGreeting
{

	public static string Greet(string name)
	{
		return "Hello, " + name + " how are you doing today?";
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Greet("Albert")); // "Hello, Albert how are you doing today?"
	}
}