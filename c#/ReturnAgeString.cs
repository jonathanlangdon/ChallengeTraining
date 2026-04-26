// return a relevant string describing age compared to a specific year

using System;
					
public class Program
{

	public static class AgeDiff 
	{
		public static string CalculateAge(int birth, int yearTo) 
		{
			int yearsToBirth = yearTo - birth;
			if (yearsToBirth > 1) return $"You are {yearsToBirth} years old.";
			if (yearsToBirth == 1) return "You are 1 year old.";
			if (yearsToBirth == 0) return "You were born this very year!";
			if (yearsToBirth == -1) return "You will be born in 1 year.";
			if (yearsToBirth < -1) return $"You will be born in {Math.Abs(yearsToBirth)} years.";
			return "invalid input";
		}
	}
	
	
	public static void Main()
	{
		Console.WriteLine(AgeDiff.CalculateAge(2003, 2020)); // expected: You are 17 years old.
		Console.WriteLine(AgeDiff.CalculateAge(2019, 2020)); // expected: You are 1 year old.
		Console.WriteLine(AgeDiff.CalculateAge(2003, 2003)); // expected: You were born this very year!
		Console.WriteLine(AgeDiff.CalculateAge(2020, 2003)); // expected: You will be born in 17 years.
		Console.WriteLine(AgeDiff.CalculateAge(2020, 2019)); // expected: You will be born in 1 year.
	}
}
