// sum up an array without the highest and lowest values

using System;
using System.Linq;

public class SumWithoutHighestLowest
{
	public static int Sum(int[] numbers)
	{
		if (numbers == null || numbers == new int[] {}) return 0;
		Array.Sort(numbers);
		return numbers.Skip(1).Take(numbers.Length - 2).Sum();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Sum(new int[] {6,2,1,8,10})); // 16
		System.Console.WriteLine(Sum(new int[] {6,2,1,8,10,10})); // 26
		System.Console.WriteLine(Sum(new int[] {})); // 0
		System.Console.WriteLine(Sum(null)); // 0
	}
}

/* another method:
numbers.Sum() - numbers.Max() - numbers.Min();
*/