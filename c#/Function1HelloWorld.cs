// used binary to send message "hello world!"

using System;
using System.Collections.Generic;

public class Function1HelloWorld
{

	public static string greet()
	{
		List<string> byteList = new List<string> {"01101000", "01100101", "01101100", "01101100", "01101111", "00100000", "01110111", "01101111", "01110010", "01101100", "01100100", "00100001"};
		string newString = "";
		foreach (string binaryChar in byteList)
		{
			newString += (char) Convert.ToInt32(binaryChar, 2);
		}
		return newString;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(greet()); // "hello world!"
	}
}