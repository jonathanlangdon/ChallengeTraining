// sum the difference of parts of an array after sorting

using System;
					
public class Program
{
	public static class Kata
	{
	  public static int SumOfDifferences(int[] arr)
	  {
		Array.Sort(arr);
		Array.Reverse(arr);
		if (arr.Length <= 1) return 0;
		int Output = 0;
		for(int i = 0; i<arr.Length-1; i++)
		{
			Output += arr[i] - arr[i+1];
		}
		return Output;
	  }
	}
	
	public static void Main()
	{Console.WriteLine("--- SumOfDifferences Output ---");

        // The expected output is provided in the comments based on the original Assert.That calls.
        
        // Assert.That(Kata.SumOfDifferences(new int[] { }), Is.EqualTo(0));
        Console.WriteLine($"{{ }} -> {Kata.SumOfDifferences(new int[] { })}"); // Expected: 0
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 0 }), Is.EqualTo(0));
        Console.WriteLine($"{{ 0 }} -> {Kata.SumOfDifferences(new int[] { 0 })}"); // Expected: 0
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 1 }), Is.EqualTo(0));
        Console.WriteLine($"{{ 1 }} -> {Kata.SumOfDifferences(new int[] { 1 })}"); // Expected: 0
        
        // Assert.That(Kata.SumOfDifferences(new int[] { -1 }), Is.EqualTo(0));
        Console.WriteLine($"{{ -1 }} -> {Kata.SumOfDifferences(new int[] { -1 })}"); // Expected: 0
        
        // Assert.That(Kata.SumOfDifferences(new int[] { -17, 17 }), Is.EqualTo(34));
        Console.WriteLine($"{{ -17, 17 }} -> {Kata.SumOfDifferences(new int[] { -17, 17 })}"); // Expected: 34 (17 - (-17))
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 2, 1, 10 }), Is.EqualTo(9));
        Console.WriteLine($"{{ 2, 1, 10 }} -> {Kata.SumOfDifferences(new int[] { 2, 1, 10 })}"); // Expected: 9 (10 - 1)
        
        // Assert.That(Kata.SumOfDifferences(new int[] { -3, -2, -1 }), Is.EqualTo(2));
        Console.WriteLine($"{{ -3, -2, -1 }} -> {Kata.SumOfDifferences(new int[] { -3, -2, -1 })}"); // Expected: 2 (-1 - (-3))
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 }), Is.EqualTo(0));
        Console.WriteLine($"{{ 1, 1, 1, 1, 1 }} -> {Kata.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 })}"); // Expected: 0 (1 - 1)
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 }), Is.EqualTo(0));
        Console.WriteLine($"{{ 0, 0, 0, 0, 0 }} -> {Kata.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 })}"); // Expected: 0 (0 - 0)
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(4));
        Console.WriteLine($"{{ 1, 2, 3, 4, 5 }} -> {Kata.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 })}"); // Expected: 4 (5 - 1)
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 0, 29, 24, 17 }), Is.EqualTo(29));
        Console.WriteLine($"{{ 0, 29, 24, 17 }} -> {Kata.SumOfDifferences(new int[] { 0, 29, 24, 17 })}"); // Expected: 29 (29 - 0)
        
        // Assert.That(Kata.SumOfDifferences(new int[] { 25, 24, -25, 2 }), Is.EqualTo(50));
        Console.WriteLine($"{{ 25, 24, -25, 2 }} -> {Kata.SumOfDifferences(new int[] { 25, 24, -25, 2 })}"); // Expected: 50 (25 - (-25))
        
        // Assert.That(Kata.SumOfDifferences(new int[] { -26, -4, -8, -8 }), Is.EqualTo(22));
        Console.WriteLine($"{{ -26, -4, -8, -8 }} -> {Kata.SumOfDifferences(new int[] { -26, -4, -8, -8 })}"); // Expected: 22 (-4 - (-26))
	}
}
