// Add the value "codewars" to the array websites 1,000 times.

using System;
using System.Collections.Generic;
using System.Linq;

public class OneThousandCodeWars
{


	public static class Kata 
	{
		public static string[] Websites;

		static Kata()
		{
			List<string> WebsiteList = new List<string>();
			WebsiteList.AddRange(Enumerable.Repeat("codewars",1000));
			Websites = WebsiteList.ToArray();
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.Websites != null);                         // expected: True
		Console.WriteLine(Kata.Websites.Length);                          // expected: 1000
		Console.WriteLine(Kata.Websites.GetType().GetElementType());      // expected: System.String
		Console.WriteLine(Array.TrueForAll(Kata.Websites, v => v == "codewars")); // expected: True
	}
}
