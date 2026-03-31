// fix a function that is supposed to swap values

using System;
using System.Linq;
					
public class Program
{
	public class Swapper
	{
		public object[] Arguments { get; private set; }

		public Swapper(object[] args)
		{
			Arguments = args;
		}

		public void SwapValues()
		{
			object[] args = new[] { Arguments[0], Arguments[1] };

			object temp = args[0];
			args[0] = args[1];
			args[1] = temp;
			Arguments = args;
		}
	}
	
	
		public static void Main()
        {
            int[] args = new[] { 1, 2 };
            
            // Setup the swapper with the arguments
            Swapper swapper = new Swapper(args.Cast<object>().ToArray());
            swapper.SwapValues(); 
            
            // Check the first value (Expected: 2)
            bool isFirstCorrect = swapper.Arguments[0].Equals(2);
            Console.WriteLine($"Index 0 is {swapper.Arguments[0]} (Expected 2) - Match: {isFirstCorrect}");
            
            // Check the second value (Expected: 1)
            bool isSecondCorrect = swapper.Arguments[1].Equals(1);
            Console.WriteLine($"Index 1 is {swapper.Arguments[1]} (Expected 1) - Match: {isSecondCorrect}");
            
            // Overall test status
            Console.WriteLine($"\nAll tests passed: {isFirstCorrect && isSecondCorrect}");
        }
}
