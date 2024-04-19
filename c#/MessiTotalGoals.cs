// total up Messi's goals

public class MessiTotalGoals
{
	public static int GetGoals(int leag1, int leag2, int leag3) => leag1 + leag2 + leag3;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetGoals(5, 10, 2)); // 17
	}
}