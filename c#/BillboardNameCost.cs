// return the cost of putting your name on a billboard without using *

using System;

public class BillboardNameCost
{
	public class Kata {
		public static double Billboard(string name, double price = 30) 
		{
			double ResultCost = 0;
			for(int i = 0; i < name.Length; i++)
			{
				ResultCost += price;
			}
			return ResultCost;
		}
	}	

	public static void Main()
	{
		Console.WriteLine(Kata.Billboard("Jeong-Ho Aristotelis"));     // expected: 600
		Console.WriteLine(Kata.Billboard("CODEWARS", 5));              // expected: 40
	}
}