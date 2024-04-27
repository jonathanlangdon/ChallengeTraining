// return how many passengers a bus driver can't take

public class EnoughSpaceOnBus
{
	public static int Enough(int cap, int on, int wait)
	{
		return cap - on > wait ? 0 : wait - (cap - on);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Enough(10, 5, 5)); // 0
		System.Console.WriteLine(Enough(100, 60, 50)); // 10
		System.Console.WriteLine(Enough(20, 5, 5)); // 0
	}
}