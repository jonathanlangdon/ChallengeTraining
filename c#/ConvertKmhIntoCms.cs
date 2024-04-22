// convert km/h into cm/s

using System;

public class ConvertKmhIntoCms
{
	public static int CockroachSpeed(double s)
	{
		return (int) Math.Floor(s * 100000 / 3600);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(CockroachSpeed(1.08)); // 30
	}
}