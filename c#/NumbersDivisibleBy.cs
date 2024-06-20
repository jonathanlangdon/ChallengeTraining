// Return an array of all numbers that are divisible by an inputed numbers

using System.Linq;

public class NumbersDivisibleBy
{
	public static int[] DivisibleBy(int[] numbers, int divisor)
	{
		return numbers.Where(num => num % divisor == 0).ToArray();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", DivisibleBy(new int[] {1,2,3,4,5,6}, 2))); // [2, 4, 6]
	}
}