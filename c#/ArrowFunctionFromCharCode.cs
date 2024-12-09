// take array of char codes and turn into letters

using System.Linq;

public class Kata
{
  public static string ArrowFunc(int[] arr)
  {
    return string.Join("", arr.Select( c => (char) c ).ToArray());
  }
	
	public static void Main(string[] args) 
	{
		System.Console.WriteLine(ArrowFunc(new int[]{84,101,115,116}));
	}
}