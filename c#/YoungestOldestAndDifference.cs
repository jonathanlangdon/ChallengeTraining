// return from list of ages, [youngest age, oldest age, difference between the youngest and oldest age]

using System;
using System.Linq;

public class YoungestOldestAndDifference
{
	public class Kata
	{
		public static int[] DifferenceInAges(int[] ages)
		{
			return new int[] {ages.Min(), ages.Max(), ages.Max() - ages.Min()};
		}
	}

	public static void Main()
	{
		Console.WriteLine(string.Join(", ", Kata.DifferenceInAges(new int[] {82, 15, 6, 38, 35}))); // expected: 6, 82, 76
		Console.WriteLine(string.Join(", ", Kata.DifferenceInAges(new int[] {57, 99, 14, 32})));    // expected: 14, 99, 85 
	}
}
