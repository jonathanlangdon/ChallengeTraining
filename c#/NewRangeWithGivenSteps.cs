// create a new int array with a given range, start, stop and step

using System;
using System.Collections.Generic;
					
public class Program
{
	public class Kata
	{
	  public static int[] GenerateRange(int min, int max, int step)
	  {
		List<int> newRange = new List<int>();
		for (int i = min; i <= max; i+=step) {
			newRange.Add(i);
		}
		return newRange.ToArray();
	  }
	}
	
	public static void Main()
    {
        RunTest(2, 10, 2, new int[] { 2, 4, 6, 8, 10 });
        RunTest(1, 10, 1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        RunTest(-10, 1, 1, new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1 });
        RunTest(1, 15, 20, new int[] { 1 });
    }

    static void RunTest(int min, int max, int step, int[] expected)
    {
        int[] result = Kata.GenerateRange(min, max, step);
        Console.WriteLine("Expected: " + string.Join(", ", expected));
        Console.WriteLine("Actual:   " + string.Join(", ", result));
        Console.WriteLine(new string('-', 40));
    }
}
