// // Logic Tests: Summing multiples of n < m

using System;
					
public class Program
{
	public class Kata
	{
	  public static int SumMul(int n, int m)
	  {
		if (n < 1 || m < n) throw new ArgumentException("ArgumentException");
		int TotalSum = 0;
		for (int i = n; i < m; i+=n)
		{
			TotalSum += i;
		}
		return TotalSum;
	  }
	}
	
	public static void Main()
	{
		Console.WriteLine(Kata.SumMul(2, 9));      // Expected: 20
		Console.WriteLine(Kata.SumMul(5, 20));     // Expected: 30 
		Console.WriteLine(Kata.SumMul(4, 123));    // Expected: 1860
		Console.WriteLine(Kata.SumMul(123, 4567)); // Expected: 86469
		try { Kata.SumMul(4, 1); } catch (Exception e) { Console.WriteLine(e.GetType().Name); }  // Expected: ArgumentException
		try { Kata.SumMul(0, 20); } catch (Exception e) { Console.WriteLine(e.GetType().Name); } // Expected: ArgumentException
	}
}
