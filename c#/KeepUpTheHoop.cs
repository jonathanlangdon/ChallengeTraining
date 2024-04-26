// return encouraging messages based on how many hoops

public class KeepUpTheHoop
{
	public static string HoopCount(int n)
	{
		if (n >= 10) return "Great, now move on to tricks";
		else return "Keep at it until you get it";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(HoopCount(9)); // keep at it
		System.Console.WriteLine(HoopCount(10)); // move on
		System.Console.WriteLine(HoopCount(11)); // move on
	}
}