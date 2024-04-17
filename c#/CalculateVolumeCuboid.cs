// calculate volume of a cuboid

public class CalculateVolumeCuboid
{
	public static double GetVolumeOfCuboid(double length, double width, double height)
	{
		return length * width * height;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(GetVolumeOfCuboid(2, 3, 4)); // 24
	}
}