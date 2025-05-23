using System;
					
public class SurfaceAreaVolumeBox
{
	
	public static int[] Get_size(int w,int h,int d)
	{
		int surfaceArea = 2 * (w * h + d * w + d * h);
		int volume = w * h * d;
		return new int[] {surfaceArea, volume};
	}
	
	
	public static void Main()
	{
		Console.WriteLine(string.Join(", ", Get_size(4, 2, 6)));
		// [ 88, 48 ]
	}
	
}