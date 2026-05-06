// return rounding to 2 places

using System;
					
public class Program
{
	public class Numbers
	{
	  public static double TwoDecimalPlaces(double number)
	  {
		  return Math.Round(number, 2);
	  }
	}
	
	public static void Main()
	{
		Console.WriteLine(Numbers.TwoDecimalPlaces(4.659725356));                  // expected: 4.66
		Console.WriteLine(Numbers.TwoDecimalPlaces(173735326.3783732637948948));   // expected: 173735326.38
		Console.WriteLine(Numbers.TwoDecimalPlaces(0));                            // expected: 0
		Console.WriteLine(Numbers.TwoDecimalPlaces(-1.235));                       // expected: -1.24
	}
}