// return just first n elements of array

using System;
using System.Linq;

public class Program
{
    public static int[] Take(int[] arr, int n)
    {
        return arr.Take(n).ToArray();
    }
	
	
	public static void Main()
	{
        Console.WriteLine($"[{string.Join(", ", Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3))}]"); //Is.EqualTo(new int[] { 0, 1, 2 }));
        Console.WriteLine($"[{string.Join(", ", Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 0))}]"); //, Is.EqualTo(new int[] { }));
        Console.WriteLine($"[{string.Join(", ", Take(new int[] { }, 3))}]"); //, Is.EqualTo(new int[] { }));
	}
}
