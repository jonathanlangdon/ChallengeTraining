// return total salary including bonus

public class DoIGetABonus
{
	public static string bonus_time(int salary, bool bonus)
	{
		return "$" + salary * (bonus ? 10 : 1);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(bonus_time(100, true)); // $1000
	}
}