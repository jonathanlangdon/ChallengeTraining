// convert number to currency format

using System;
					
public class Program
{
	public class Kata
	{
	  public static string FormatMoney(double amount)
	  {
		return $"${amount.ToString("F2")}";
	  }
	}
	
	public static void Main()
    {
		Console.WriteLine(Kata.FormatMoney(39.99)); // expected: $39.99
		Console.WriteLine(Kata.FormatMoney(3));     // expected: $3.00
		Console.WriteLine(Kata.FormatMoney(956.7596820181124)); // expected: $956.76
    }

}
