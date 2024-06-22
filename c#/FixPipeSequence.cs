// create sequential list given a list with missing integers

using System.Collections.Generic;
using System.Linq;

public class FixPipeSequence
{
	public static List<int> PipeFix(List<int> numbers)
	{
		return Enumerable.Range(numbers[0],numbers.Last() - numbers[0] + 1).ToList();
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", PipeFix(new List<int> {1,3,5,6}))); // 1,2,3,4,5,6
		System.Console.WriteLine(string.Join(", ", PipeFix(new List<int> {6, 9}))); // 6, 7, 8, 9
	}
}