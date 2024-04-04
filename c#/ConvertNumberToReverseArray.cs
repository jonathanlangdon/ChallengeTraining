// convert a number to an array reversing the digits

using System;
using System.Linq;


public class ConvertNumberToReverseArray
{
	public static long[] Digitize(long n)
	{
      return n.ToString()
              .Reverse()
              .Select(t => Convert.ToInt64(t.ToString()))
              .ToArray();
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(string.Join(" ", Digitize(35231))); // [1, 3, 2, 5, 3]
	}
}