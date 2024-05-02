// calculate final grade of a student based on exam and projects

public class FinalGradeWithExamProjects
{
	public static int FinalGrade(int exam, int projects)
	{
		if (exam > 90 || projects > 10) return 100;
		if (exam > 75 && projects >= 5) return 90;
		if (exam > 50 && projects >= 2) return 75;
		return 0;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(FinalGrade(91, 4)); // 100
		System.Console.WriteLine(FinalGrade(19, 14)); // 100
		System.Console.WriteLine(FinalGrade(90, 4)); // 75
		System.Console.WriteLine(FinalGrade(69, 6)); // 75
		System.Console.WriteLine(FinalGrade(90, 5)); // 90
		System.Console.WriteLine(FinalGrade(14, 4)); // 0
	}
}