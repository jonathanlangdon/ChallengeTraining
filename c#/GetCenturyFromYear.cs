// return what century a year belongs to

using System;

public class GetCenturyFromYear
{

	public static int CenturyFromYear(int year)
	{
		return (int)Math.Ceiling((double)year / 100);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(CenturyFromYear(1705)); // 18
		Console.WriteLine(CenturyFromYear(1900)); // 19
	}
}