// given current position and dice roll (x2) determine new position

public class TerminalGameMove
{
	public static int Move(int position, int roll) => position + roll * 2;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Move(2, 5)); // 12
	}
}