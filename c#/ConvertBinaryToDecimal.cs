// convert binary to decimal

public class ConvertBinaryToDecimal
{
	public static int binToDec(string binaryStr)
	{
		return System.Convert.ToInt32(binaryStr, 2);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(binToDec("1101")); // 13
	}
}