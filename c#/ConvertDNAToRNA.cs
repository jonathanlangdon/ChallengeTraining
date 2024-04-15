// convert dna to rna (replace all T's with U's)

using System;

public class ConvertDNAToRNA
{
	public static string DnaToRna(string dna) => dna.Replace('T', 'U');

	public static void Main(string[] args)
	{
		Console.WriteLine(DnaToRna("GCAT")); //GCAU
	}
}