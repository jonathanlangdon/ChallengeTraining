// return Hello, {name} or just "Hello, World!" if no name given

public class HelloNameWorld
{
	public static string Hello()
	{
		return "Hello, World!";
	}

	public static string Hello(string name)
	{
		if (name == "") return "Hello, World!";
		string ProperName = name.Substring(0,1).ToUpper() + name.Substring(1,name.Length - 1).ToLower();
		return $"Hello, {ProperName}!";
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(Hello("SillY")); // Hello, Silly!
		System.Console.WriteLine(Hello("")); // Hello, World!
		System.Console.WriteLine(Hello()); // Hello, World!
	}
}