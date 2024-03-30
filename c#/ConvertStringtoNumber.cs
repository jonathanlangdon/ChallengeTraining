// convert a string to an int

using System;

public class ConvertStringtoNumber
{

	public static int StringToNumber(String str)
	{
		return int.Parse(str);
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(StringToNumber("183")); // 183
	}
}