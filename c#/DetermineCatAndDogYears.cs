// determine dog and cat age in humanYears, catYears, dogYears

public class DetermineCatAndDogYears
{
	public static int[] humanYearsCatYearsDogYears(int humanYears)
	{
		bool olderThanTwo = humanYears > 2;
		bool olderThanOne = humanYears > 1;
		int catYears = 15 + (olderThanTwo ? 9 + (humanYears - 2) * 4 : olderThanOne ? 9 : 0);
		int dogYears = 15 + (olderThanTwo ? 9 + (humanYears - 2) * 5 : olderThanOne ? 9 : 0);
		return new int[] {humanYears, catYears, dogYears};
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", humanYearsCatYearsDogYears(1))); // 1, 15, 15
		System.Console.WriteLine(string.Join(", ", humanYearsCatYearsDogYears(2))); // 2, 24, 24
		System.Console.WriteLine(string.Join(", ", humanYearsCatYearsDogYears(10))); // 10, 56, 64
	}
}