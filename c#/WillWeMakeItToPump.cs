// determine whether we have enough fuel to make it to the pump

using System;

public class WillWeMakeItToPump
{
	public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
	{
		return mpg * fuelLeft >= distanceToPump;
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(ZeroFuel(50, 25, 2)); // true
		Console.WriteLine(ZeroFuel(100, 50, 1)); // false
	}
}