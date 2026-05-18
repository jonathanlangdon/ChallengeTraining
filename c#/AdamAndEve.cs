// create class Human and subclasses for Man and Woman

using System;

public class AdamAndEve
{
	public class Human{}
	public class Man : Human{}
	public class Woman : Human{}

	public class God
	{
		public static Human[] Create()
		{
			return new Human[]
			{
				new Man(),
				new Woman()
			};
		}
	}

	public static void Main()
	{
		Human[] humans = God.Create();

		Console.WriteLine(humans[0] is Human); // expected: True
		Console.WriteLine(humans[0] is Man);   // expected: True 

		Console.WriteLine(humans[1] is Human); // expected: True
		Console.WriteLine(humans[1] is Woman); // expected: True
	}
}