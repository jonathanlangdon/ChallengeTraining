// print arrays (even array of arrays)

using System;
using System.Linq;

public class Program
{
  public static string PrintArray(object[] array)
  {
    return string.Join(",",array.Select(x=>x is Object[]?PrintArray(x as object[]):x));
  }
	
	public static void Main()
	{
		var data = new object[] { 2, 4, 5, 2 };
		Console.WriteLine(PrintArray(data)); //, Is.EqualTo("2,4,5,2"), "int test failed");
		var data3 = new object[]
			{
				new string[] { "hello", "this", "is", "an", "array!" },
				new string[] { "a", "b", "c", "d", "e!" }
			};
		Console.WriteLine(PrintArray(data3));
	}
}
