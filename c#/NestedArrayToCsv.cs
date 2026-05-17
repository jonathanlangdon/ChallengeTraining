// convert a nested Array into a CSV

using System;

public class NestedArrayToCsv
{

	public static class Kata
	{
		public static string ToCsvText(int[][] array)
		{
			return string.Join("\n", array.Select(x => string.Join(",", x)));
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.ToCsvText(new[]
										 {
											 new[] {0, 1, 2, 3, 45},
											 new[] {10, 11, 12, 13, 14},
											 new[] {20, 21, 22, 23, 24},
											 new[] {30, 31, 32, 33, 34}
										 }));
		// expected:
		// 0,1,2,3,45
		// 10,11,12,13,14
		// 20,21,22,23,24
		// 30,31,32,33,34

		Console.WriteLine(Kata.ToCsvText(new[]
										 {
											 new[] {-25, 21, 2, -33, 48},
											 new[] {30, 31, -32, 33, -34}
										 }));
		// expected:
		// -25,21,2,-33,48
		// 30,31,-32,33,-34

		Console.WriteLine(Kata.ToCsvText(new[]
										 {
											 new[] {5, 55, 5, 5, 55},
											 new[] {6, 6, 66, 23, 24},
											 new[] {666, 31, 66, 33, 7}
										 }));
		// expected:
		// 5,55,5,5,55
		// 6,6,66,23,24
		// 666,31,66,33,7
	}
}