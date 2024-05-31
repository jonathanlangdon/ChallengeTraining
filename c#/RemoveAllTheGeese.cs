// remove all geese from a list

using System.Collections.Generic;
using System.Linq;

public class RemoveAllTheGeese
{
	public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
	{
		string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
		return birds.Except(geese);
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(string.Join(", ", GooseFilter(new string[] {"Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"})));
		//  ["Mallard", "Hook Bill", "Crested", "Blue Swedish"]
	}
}

// alternate line:
// return birds.Where((bird, index) => !geese.Contains(bird)).ToArray();