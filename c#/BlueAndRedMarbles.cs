// calculate probability of drawing another blue

public static class BlueAndRedMarbles {
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
		uint blueLeft = blueStart - bluePulled;
		uint redLeft = redStart - redPulled;
		uint totalLeft = blueLeft + redLeft;
        return (double) blueLeft / totalLeft;
    }

	public static void Main()
	{
		System.Console.WriteLine(GuessBlue(5, 5, 2, 3)); // .6
	}
}
