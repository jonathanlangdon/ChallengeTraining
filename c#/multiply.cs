// This is a top-level statement
using System;

public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}

public class Program {
    public static void Main() {
        int result = CustomMath.multiply(2, 1);
        Console.WriteLine(result);
    }
}
