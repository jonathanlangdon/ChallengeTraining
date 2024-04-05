// return how many Liters of water needed based on hours cycling

using System;

public class HydratedForCycling
{

	public static int Litres(double time) => (int) time / 2;

	public static void Main(string[] args)
	{
		Console.WriteLine(Litres(1.4)); // 0
		Console.WriteLine(Litres(12.3)); // 6
		Console.WriteLine(Litres(11.8)); // 5
		Console.WriteLine(Litres(1787)); // 893
	}
}