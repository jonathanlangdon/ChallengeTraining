// return pricing for bottles duty or duty free

public class PricingDutyFreeHoliday
{
	public static int DutyFree(int normPrice, int discount, int holidayCost)
	{
		return (int) (holidayCost / (normPrice * discount * .01));
	}
	public static void Main(string[] args)
	{
		System.Console.WriteLine(DutyFree(12, 50, 1000)); // 166
		System.Console.WriteLine(DutyFree(17, 10, 500)); // 294
		System.Console.WriteLine(DutyFree(24, 35, 3000)); // 357
	}
}