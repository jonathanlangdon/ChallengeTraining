// determine price of mangos

public class PriceOfMangoes {
		
	public static int Mango(int quantity, int price)
	{
		int remainder = quantity % 3;
		return quantity / 3 * price * 2 + remainder * price;
	}
  
	public static void Main()
	{
		Console.WriteLine(Mango(3, 2)); // 4
		Console.WriteLine(Mango(4, 2)); // 6
		Console.WriteLine(Mango(5, 2)); // 8
		Console.WriteLine(Mango(6, 2)); // 8
		Console.WriteLine(Mango(7, 2)); // 10
	}
}