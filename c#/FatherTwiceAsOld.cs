// calculate how many years until father is/was twice as old as son
using System;

public class FatherTwiceAsOld
{
	public static int TwiceAsOld(int dadYears, int sonYears)
	{
		return Math.Abs(dadYears - sonYears * 2);
	}
	public static void Main(string[] args)
	{
		System.Console.WriteLine(TwiceAsOld(30, 0)); // 30
		System.Console.WriteLine(TwiceAsOld(30, 7)); // 16
		System.Console.WriteLine(TwiceAsOld(45, 30)); // 15
	}
}