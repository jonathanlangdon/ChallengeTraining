// combine two strings

using System;
					
public class Program
{
	public static class Kata
	{
		public static string CombineNames(string first, string last)
		{
			return $"{first} {last}";
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.CombineNames("James", "Stevens")); // expected: James Stevens
	}
}