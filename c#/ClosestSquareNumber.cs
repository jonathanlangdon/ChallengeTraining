// round to the closest square

using System;
					
public class Program
{
	public static class Kata
	{
	  public static int NearestSq(int n)
	  {
		  return (int)Math.Pow(Math.Round(Math.Sqrt(n)),2);
	  }
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.NearestSq(1));    // expected: 1
		Console.WriteLine(Kata.NearestSq(2));    // expected: 1 
		Console.WriteLine(Kata.NearestSq(10));   // expected: 9
		Console.WriteLine(Kata.NearestSq(111));  // expected: 121
		Console.WriteLine(Kata.NearestSq(9999)); // expected: 10000
	}
}
