// fix an object that is not returning correctly

using System;
using System.Collections.Generic;

public class FixObjectNotReturning
{
	public class Kata
	{
		public static Dictionary<string,string> Mystery()
		{
			Dictionary<string, string> results = new Dictionary<string, string>();
			results.Add("sanity","hello");
			return results;
		}
	}
	
	public static void Main()
	{
		var result = Kata.Mystery();
		Console.WriteLine(string.Join(", ", result)); // expected: [sanity, hello]
	}
}
