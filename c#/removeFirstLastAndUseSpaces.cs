// take string list, remove first and last and separate with spaces instead of commas

using System;
					
public class Program
{
	public static class Kata
	{
	  public static string Array(string s)
	  {
		  string[] ElementArray = s.Split(",");
		  if (ElementArray.Length <= 2) return null;
		  return string.Join(" ", ElementArray[1..^1]);
	  }
	}
	
	public static void Main()
    {
        // Expected: null
        Console.WriteLine("Input: \"\"         | Expected: null  | Actual: " + (Kata.Array("") ?? "null"));
        
        // Expected: null
        Console.WriteLine("Input: \"1\"        | Expected: null  | Actual: " + (Kata.Array("1") ?? "null"));
        
        // Expected: null
        Console.WriteLine("Input: \"1,3\"     | Expected: null  | Actual: " + (Kata.Array("1, 3") ?? "null"));
        
        // Expected: "2"
        Console.WriteLine("Input: \"1,2,3\"    | Expected: 2     | Actual: " + (Kata.Array("1,2,3") ?? "null"));
        
        // Expected: "2 3"
        Console.WriteLine("Input: \"1,2,3,4\"  | Expected: 2 3   | Actual: " + (Kata.Array("1,2,3,4") ?? "null"));
    }
}
