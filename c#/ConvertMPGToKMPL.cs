// Convert MPG to Km per Liter

using System;

public class ConvertMPGToKMPL
{

	public static class Kata
	{
		public static double Converter(int mpg)
		{
			private const Double GalToL = 4.54609188;
			private const Double KmToMi = 1.609344;
			return Math.Round(mpg * KmToMi / GalToL, 2);
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.Converter(12)); // expected: 4.25
		Console.WriteLine(Kata.Converter(24)); // expected: 8.50
		Console.WriteLine(Kata.Converter(36)); // expected: 12.74
	}
}