// calculate body mass index given weight and height

using System;

public class CalculateBMIWithCategory
{

	public static string Bmi(double weight, double height)
	{
		double BmiValue = weight / (height * height);
		if (BmiValue <= 18.5) return "Underweight";
		if (BmiValue <= 25.0) return "Normal";
		if (BmiValue <= 30) return "Overweight";
		else return "Obese";
	}

	public static void Main(string[] args)
	{
		Console.WriteLine(Bmi(30.1, 1)); // Obese
		Console.WriteLine(Bmi(30, 1)); // Overweight
		Console.WriteLine(Bmi(29.9, 1)); // Overweight
		Console.WriteLine(Bmi(25.1, 1)); // Overweight
		Console.WriteLine(Bmi(80, 1.8)); // Normal
		Console.WriteLine(Bmi(24.9, 1)); // Normal
		Console.WriteLine(Bmi(18.6, 1)); // Normal
		Console.WriteLine(Bmi(18.5, 1)); // Underweight
		Console.WriteLine(Bmi(18.4, 1)); // Underweight
	}
}