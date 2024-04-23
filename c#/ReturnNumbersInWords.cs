// return number 0-9 in words

using System.Collections.Generic;

public class ReturnNumbersInWords
{
	public static string SwitchItUp(int number)
	{
		Dictionary<int, string> numberMap = new Dictionary<int, string>();
		numberMap[0] = "Zero";
		numberMap[1] = "One";
        numberMap[2] = "Two";
        numberMap[3] = "Three";
        numberMap[4] = "Four";
        numberMap[5] = "Five";
        numberMap[6] = "Six";
        numberMap[7] = "Seven";
        numberMap[8] = "Eight";
        numberMap[9] = "Nine";

		return numberMap[number];
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(SwitchItUp(1)); // One
	}
}