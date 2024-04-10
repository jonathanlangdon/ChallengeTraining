// return true/false if hero will survive given bullets and dragons

using System;

public class HeroGonnaSurvive
{

	public static bool Hero(int bullets, int dragons) => bullets / 2 >= dragons;

	public static void Main(string[] args)
	{
		Console.WriteLine(Hero(10, 5)); // true
		Console.WriteLine(Hero(100, 40)); // true
		Console.WriteLine(Hero(4, 5)); // false
		Console.WriteLine(Hero(1500, 751)); // false
		Console.WriteLine(Hero(0, 1)); // false
		Console.WriteLine(Hero(7, 4)); // false
	}
}