// fix basic variable assignment

public class BasicVariableAssignment
{
	public static string A = "code";
	public static string B = "wa.rs";
	public static string Name = A + B;

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Name); //codewa.rs
	}
}

/* was the following:

  public static A = "code";
  public static B = "wa.rs";
  public static Name = A + B;

*/