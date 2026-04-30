// fix a template string of liking foods

using System;

public class CheeseMilkChocolate
{
	public static class Kata 
	{
		public static string buildString(string[] args) => $"I like {String.Join(", ", args)}!";
	}

	public static void Main()
	{
		Console.WriteLine(Kata.buildString(new string[] {"Cheese","Milk","Chocolate"})); // expected: I like Cheese, Milk, Chocolate!
		Console.WriteLine(Kata.buildString(new string[] {"Cheese","Milk"}));             // expected: I like Cheese, Milk!
		Console.WriteLine(Kata.buildString(new string[] {"Chocolate"}));                 // expected: I like Chocolate!
	}
}
