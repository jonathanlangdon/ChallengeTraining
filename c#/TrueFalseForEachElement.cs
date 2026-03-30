// return true if function returns true for every item in an array

using System;
					
public class Program
{
	public class Kata
	{
		public static bool All(int[] arr, Func<int, bool> fun)
		{
			foreach (int element in arr)
			{
				if (!fun(element)) return false;
			}
			return true;
		}
	}
	
	
	public static void Main()
    {
        int[] xs = { 2, 4, 6, 10 };
        Func<int, bool> isEven = v => v % 2 == 0;

        // Expected: True
        Console.WriteLine("All items are even: " + Kata.All(xs, isEven)); 
        
        // Expected: False
        Console.WriteLine("Not all items are less than ten: " + Kata.All(xs, v => v < 10)); 
        
        // Expected: False
        Console.WriteLine("No items are odd: " + Kata.All(xs, v => v % 2 != 0)); 
        
        // Expected: True
        Console.WriteLine("An empty array should return true: " + Kata.All(new int[]{}, isEven)); 
    }
}
