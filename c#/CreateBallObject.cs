// create Ball object that accepts either one or no arguments

public class CreateBallObject
{
	public class Ball {
		public string ballType { get; set; }
		
		public Ball(string ballType = "regular") 
        {
			this.ballType = ballType;
		}
	}

	public static void Main(string[] args)
	{
		Ball ball1 = new Ball();
		Ball ball2 = new Ball("super");
		System.Console.WriteLine(ball1.ballType); // "regular"
		System.Console.WriteLine(ball2.ballType); // "super"
	}
}
