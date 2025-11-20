// Function to return day of the week based on number

using System;
using System.Collections.Generic;

public class Program
{
    public class Kata
    {
      
        static Dictionary<int, string> dayMap = new Dictionary<int, string>()
        {
            { 1, "Sunday" },
            { 2, "Monday" },
            { 3, "Tuesday" },
            { 4, "Wednesday" },
            { 5, "Thursday" },
            { 6, "Friday" },
            { 7, "Saturday" }
        };

        public static string WhatDay(int n)
        {
            if (dayMap.TryGetValue(n, out string day))
            {
                return day;
            }
            else
            {
                return "Wrong, please enter a number between 1 and 7";
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine(Kata.WhatDay(1)); // Sunday
        Console.WriteLine(Kata.WhatDay(2)); // Monday
        Console.WriteLine(Kata.WhatDay(3)); // Tuesday
        Console.WriteLine(Kata.WhatDay(4)); // Wednesday
        Console.WriteLine(Kata.WhatDay(5)); // Thursday
        Console.WriteLine(Kata.WhatDay(6)); // Friday
        Console.WriteLine(Kata.WhatDay(7)); // Saturday
        Console.WriteLine(Kata.WhatDay(-1)); // Wrong, please enter a number between 1 and 7
        Console.WriteLine(Kata.WhatDay(0)); // Wrong, please enter a number between 1 and 7
        Console.WriteLine(Kata.WhatDay(8)); // Wrong, please enter a number between 1 and 7
        Console.WriteLine(Kata.WhatDay(20)); // Wrong, please enter a number between 1 and 7
    }
}