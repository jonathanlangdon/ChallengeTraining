// determine if number is hotter than the sun

using System;
					
public class Program
{
	public class Kata
	{
	  public static string Apple(object n)
	  {
		  int number = Convert.ToInt32(n);
		  return (Math.Pow(number, 2) > 1000) ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
	  }
	}
	
	public static void Main()
	{
		Console.WriteLine("Sample Tests:");
		Console.WriteLine(new string('-', 50));

		// Test 1
		Console.WriteLine("Testing with input: \"50\"");
		Console.WriteLine("Expected: It's hotter than the sun!!");
		Console.WriteLine($"Actual:   {Kata.Apple("50")}");
		Console.WriteLine(new string('-', 50));

		// Test 2
		Console.WriteLine("Testing with input: 4");
		Console.WriteLine("Expected: Help yourself to a honeycomb Yorkie for the glovebox.");
		Console.WriteLine($"Actual:   {Kata.Apple(4)}");
		Console.WriteLine(new string('-', 50));
	}
}
