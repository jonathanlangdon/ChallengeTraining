// calculate fibonacci also including negative numbers

using System;
using System.Numerics;

public class MillionthFibonacciKata {


    public static long fib(int n)
    {
		bool isNegative = n < 0;
		if (isNegative) n = - n;
		long currentValue = 1;
		long lastValue = 0;
		long secondToLastValue = 0;
    int count = 1;

        while (count < n)
        {
            long oldCurValue = currentValue; 
            currentValue += lastValue; 
            secondToLastValue = lastValue;
            lastValue = oldCurValue;
            count += 1;
        }
        
        if (n == 0) return 0;
		if (isNegative && n % 2 == 0) return -currentValue;
        return currentValue;
    }

    public static void Main(string[] args)
    {
        // Console.WriteLine(fib(-5)); // 5
        // Console.WriteLine(fib(-4)); // -3
        // Console.WriteLine(fib(-3)); // 2
        // Console.WriteLine(fib(-2)); // -1
        // Console.WriteLine(fib(-1)); // 1
        // Console.WriteLine(fib(0)); // 0
        // Console.WriteLine(fib(1)); // 1
        // Console.WriteLine(fib(2)); // 1
        // Console.WriteLine(fib(3)); // 2
        // Console.WriteLine(fib(4)); // 3
        // Console.WriteLine(fib(5)); // 5
        // Console.WriteLine(fib(6)); // 8
    }
}
