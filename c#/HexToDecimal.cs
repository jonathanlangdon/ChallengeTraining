using System;
					
public class HexToDecimal
{
	

	public static int HexToDec(string hexString)
	{
		if (hexString[0] == '-')
		{
			return -1 * Convert.ToInt32(hexString.Substring(1), 16);
		}
		else
		{
			return Convert.ToInt32(hexString, 16);
		}
	}
	
	
	public static void Main()
	{
		Console.WriteLine(HexToDec("1")); //1
		Console.WriteLine(HexToDec("a")); //10
		Console.WriteLine(HexToDec("FF")); //255
		Console.WriteLine(HexToDec("-C")); //-12
	}
	
}