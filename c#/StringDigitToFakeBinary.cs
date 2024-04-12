// 1-5 become 0 and 6-9 become 1

using System;
using System.Linq;

public class StringDigitToFakeBinary
{

	public static string FakeBin(string numString)
	{
    	return string.Concat(numString.Select(a => a < '5' ? "0" : "1"));
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(FakeBin("0123456789")); // 0000011111
	}
}



/* 
initial try:
		string NewFakeBinary = "";

		foreach (char digit in digitString)
		{
			if (digit - '0' < 5) NewFakeBinary += "0";
			else NewFakeBinary += "1";
		}
		return NewFakeBinary;
*/