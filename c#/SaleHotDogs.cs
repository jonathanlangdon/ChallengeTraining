// complete a ternary operator

public class SellingHotDogs
{
	public static int SaleHotDogs(int n)
	{
		return n < 5 ? n * 100 : n < 10 ? n * 95 : n * 90;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(SaleHotDogs(4)); // 400
		System.Console.WriteLine(SaleHotDogs(5)); // 475
	}
}