// calculate how many pages needed for copies

using System;

public class SchoolPaperWork
{

	public static int Paperwork(int n, int m)
	{
		return (n < 0 || m < 0) ? 0 : n * m;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Paperwork(5, 5)); // 25
		Console.WriteLine(Paperwork(-5, 5)); // 0
	}
}