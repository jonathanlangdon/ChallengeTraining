// return a new list of the items that are divisible by its index

using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static class Kata
	{
		public static List<int> MultipleOfIndex(List<int> xs)
		{
			return xs.Where((num, index) => (index == 0) ? num == 0 ? true : false : num % index == 0).ToList();
		}
	}
	
	public static void Main()
	{
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {22, -6, 32, 82, 9, 25}))); // expected: -6, 32, 25
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {68, -1, 1, -7, 10, 10}))); // expected: -1, 10
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {11, -11}))); // expected: -11
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {-56,-85,72,-26,-14,76,-27,72,35,-21,-67,87,0,21,59,27,-92,68}))); // expected: -85, 72, 0, 68
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {28,38,-44,-99,-13,-54,77,-51}))); // expected: 38, -44, -99
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {-1,-49,-1,67,8,-60,39,35}))); // expected: -49, 8, -60, 35
		Console.WriteLine(string.Join(", ", Kata.MultipleOfIndex(new List<int> {0, 2, 3, 6, 9}))); // expected: 0, 2, 6
	}
}