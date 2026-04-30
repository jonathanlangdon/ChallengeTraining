// convert USD to chinese Yuan

using System;

public class ConvertUSDToChineseYuan
{
	public static class Kata
	{
		public static string Usdcny(int usd)
		{
			return $"{(usd * 6.75).ToString("F2")} Chinese Yuan";
		}
	}

	public static void Main()
	{
		Console.WriteLine(Kata.Usdcny(15));   // expected: 101.25 Chinese Yuan
		Console.WriteLine(Kata.Usdcny(465));  // expected: 3138.75 Chinese Yuan
		Console.WriteLine(Kata.Usdcny(7242)); // expected: 48883.50 Chinese Yuan
	}
}
