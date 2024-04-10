// calculate the time in milliseconds

using System;

public class ClockSinceMidnight
{

	public static int Past(int h, int m, int s) => ((h * 60 + m) * 60 + s) * 1000;

	public static void Main(string[] args)
	{
		Console.WriteLine(Past(0, 1, 1)); // 61000
		Console.WriteLine(Past(1, 1, 1)); // 3661000
	}
}