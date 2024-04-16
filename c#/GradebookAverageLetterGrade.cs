// return average and associated letter grade

using System.Linq;

public class GradebookAverageLetterGrade
{

	public static char GetGrade(int s1, int s2, int s3)
	{
		var gradeArr = new int[] {s1, s2, s3};
		double avgGrade = gradeArr.Average();
		if (avgGrade >= 90) return 'A';
		if (avgGrade >= 80) return 'B';
		if (avgGrade >= 70) return 'C';
		if (avgGrade >= 60) return 'D';
		return 'F';
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetGrade(90, 90, 90)); // A
		System.Console.WriteLine(GetGrade(85, 90, 95)); // A
		System.Console.WriteLine(GetGrade(89, 89, 89)); // B
		System.Console.WriteLine(GetGrade(81, 81, 81)); // B
		System.Console.WriteLine(GetGrade(79, 79, 79)); // C
		System.Console.WriteLine(GetGrade(69, 69, 69)); // D
		System.Console.WriteLine(GetGrade(59, 59, 59)); // F
	}
}