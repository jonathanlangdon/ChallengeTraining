// calculate either area or perimeter of a polygon
// square => area... rectangle => perimeter

public class AreaOrPerimeterPolygon
{
	public static int AreaOrPerimeter(int l, int w)
	{
		return l == w ? l * w : 2 * l + 2 * w;
	}

	public static void Main(string[] args)
	{
		System.Console.WriteLine(AreaOrPerimeter(5, 5)); // 25
		System.Console.WriteLine(AreaOrPerimeter(5, 4)); // 18
	}
}