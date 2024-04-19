// return 3rd angle if given 1st 2 angles of triangle

using System;

public class ThirdAngleOfTriangle
{
	public static int OtherAngle(int a, int b) => 180 - a - b;

	public static void Main(string[] args)
	{
		Console.WriteLine(OtherAngle(30, 60)); // 90
	}
}