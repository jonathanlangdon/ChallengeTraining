// fix a function about greeting

public static class GreetMyLoveJohnny
{
  public static string greet(string name)
  {
	  return $"Hello, {(name == "Johnny" ? "my love" : name)}!";
  }

	public static void Main(string[] args)
	{
		System.Console.WriteLine(greet("John")); // Hello, John!
		System.Console.WriteLine(greet("Johnny")); // Hello, my love!
	}

}