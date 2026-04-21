// determine if an array contains an item(int)

using System;
using System.Linq;
					
public class Program
{
	public class Kata
	{
	  public static bool Include(int[] arr, int item)
	  {
		return arr.Contains(item);
	  }
	}
	
	public static void Main()
    {
	  Console.WriteLine(Kata.Include(new int[] { 1,2,3,4 }, 3)); // True
	  Console.WriteLine(Kata.Include(new int[] { 1,2,4,5 }, 3)); // False
    }

}
