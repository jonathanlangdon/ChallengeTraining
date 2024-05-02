// debug greeting program

public class DebugHelloGreeting
{
	public static string SayHello(string name) => $"Hello, {name}";

	public static void Main(string[] args)
	{
		System.Console.WriteLine(SayHello("Spock")); // "Hello, Spock"
	}
}