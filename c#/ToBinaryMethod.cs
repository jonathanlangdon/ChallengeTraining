// return binary of an integer

public class ToBinaryMethod
{
	public static int ToBinary(int n)
	{
		return int.Parse(System.Convert.ToString(n, 2));
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(ToBinary(8)); // 1000
		System.Console.WriteLine(ToBinary(11)); // 1011
	}
}