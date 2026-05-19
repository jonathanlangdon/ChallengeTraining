// shorten a long date to just the day and month

using System;

public class ShortenDateFormat
{

	public static class Kata
	{
		public static string ShortenToDate(string longDate) => longDate.Split(",")[0];
	}

	public static void Main()
	{
		Console.WriteLine(Kata.ShortenToDate("Friday May 2, 9am"));        // expected: Friday May 2 
		Console.WriteLine(Kata.ShortenToDate("Tuesday January 29, 10pm")); // expected: Tuesday January 29
		Console.WriteLine(Kata.ShortenToDate("Monday December 25, 10pm")); // expected: Monday December 25
	}
}