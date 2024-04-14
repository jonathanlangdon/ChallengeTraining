// total the cost of a vacation

public class CarRentalCosts
{
	public static int RentalCarCost(int days)
	{
		return days * 40 - (days >= 7 ? 50 : days >= 3 ? 20 : 0);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(RentalCarCost(2)); // 80
		System.Console.WriteLine(RentalCarCost(3)); // 100
		System.Console.WriteLine(RentalCarCost(4)); // 140
		System.Console.WriteLine(RentalCarCost(6)); // 220
		System.Console.WriteLine(RentalCarCost(7)); // 230
		System.Console.WriteLine(RentalCarCost(8)); // 270
	}
}