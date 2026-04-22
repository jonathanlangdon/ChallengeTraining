// return a string alteration of manipulation of number inputs

using System;
					
public class Program
{
	public class Kata
	{
	  public static string Derive(double coefficient, double exponent)
	  {
		return $"{coefficient * exponent}x^{exponent-1}";
	  }
	}
	
	public static void Main()
    {
		Console.WriteLine(Kata.Derive(7, 8)); // expected: 56x^7
		Console.WriteLine(Kata.Derive(5, 9)); // expected: 45x^8
    }

}
