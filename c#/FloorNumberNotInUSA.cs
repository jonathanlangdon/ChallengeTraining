// What's the floor number when not in USA?

public class FloorNumberNotInUSA
{
	public static int GetRealFloor(int n)
	{
		int NonUSAFloorNum = n;
		if (n > 0) NonUSAFloorNum -= 1;
		if (n > 12) NonUSAFloorNum -= 1;
		return NonUSAFloorNum;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetRealFloor(1)); // 0
		System.Console.WriteLine(GetRealFloor(0)); // 0
		System.Console.WriteLine(GetRealFloor(5)); // 4
		System.Console.WriteLine(GetRealFloor(15)); // 13
		System.Console.WriteLine(GetRealFloor(-3)); // -3
	}
}