// repeat a string n number of times

using System;

public class StringRepitition 
{

	public static string RepeatStr(int n, string s)
	{
		string newStr = "";
		for (int i = 0; i < n; i++)
		{
			newStr += s;
		}
		return newStr;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(RepeatStr(3, "this")); // "thisthisthis"
	}
}