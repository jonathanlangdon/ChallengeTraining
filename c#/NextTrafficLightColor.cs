// return the next state for a traffic light color

using System.Collections.Generic;

public class NextTrafficLightColor
{

	static Dictionary<string, string> TrafficColors = new Dictionary<string, string>
	{
		{ "green", "yellow" },
		{ "yellow", "red" },
		{ "red", "green" }
	};

	public static string UpdateLight(string current)
	{
		return TrafficColors[current];
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(UpdateLight("green")); // yellow
		System.Console.WriteLine(UpdateLight("yellow")); // red
		System.Console.WriteLine(UpdateLight("red")); // green
	}
}