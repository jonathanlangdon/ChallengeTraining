// check and see if an array contains a value

using System;
using System.Linq;

public class OnlyNeedOneX
{
	public static bool Check(object[] a, object x) => a.Contains(x);

	public static void Main(string[] args)
	{
		Console.WriteLine(Check(new object[] { 66, 101 }, 66)); //true
		Console.WriteLine(Check(new object[] { 66, 101 }, 67)); //false
	}
}